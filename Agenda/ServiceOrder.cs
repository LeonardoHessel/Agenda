using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class ServiceOrder : Connection
    {
        public long ID { set; get; }
        public Customer Customer { set; get; }
        public string WhoRequested { set; get; }
        public User User { set; get; }
        public string Subject { set; get; }
        public string Description { set; get; }
        public string Solution { set; get; }
        public Product Product { set; get; }
        public string Service { set; get; }
        public string Status { set; get; }
        public DateTime Creation { set; get; }
        public DateTime Start { set; get; }
        public DateTime End { set; get; }
        public bool Active { set; get; }

        public static ServiceOrder QueryServiceOrder { private set; get; }
        public static List<ServiceOrder> QueryServiceOrders { private set; get; }

        public bool Insert()
        {
            string sql = @"INSERT INTO `serviceorder` (`customer_id`,`who_requested`,`user_id`,`subject`,
            `description`,`solution`,`product_id`,`service_mode`,`status`,`creation`,`start`,`end`) 
            VALUES (@customer_id,@who_requested,@user_id,@subject,@description,@solution,@product_id,
            @service,@status,@creation,@start,@end)";
            TextCommand(sql);
            Parameters("Insert");
            if (Execute())
            {
                this.ID = Connection.LastInsertID;
                this.Active = true;
                return true;
            }
            return false;
        }

        public static bool GetByID(long serviceOrder_id)
        {
            ServiceOrder order = new ServiceOrder();
            string sql = @"SELECT * FROM `serviceorder` WHERE `id`=@id";
            order.TextCommand(sql);
            order.AddParameter("id", serviceOrder_id);
            if (order.ExecuteQuery())
            {
                ServiceOrder.QueryServiceOrder = order.TableToList(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public static bool SearchAll()
        {
            ServiceOrder order = new ServiceOrder();
            string sql = @"SELECT * FROM `serviceorder`";
            order.TextCommand(sql);
            
            if (order.ExecuteQuery())
            {
                ServiceOrder.QueryServiceOrders = order.TableToList(Connection.SelectedTable);
                return true;
            }
            return false;
        }

        public bool Update()
        {
            string sql = @"UPDATE `serviceorder` SET `customer_id`=@customer_id,`who_requested`=@who_requested,
            `user_id`=@user_id,`subject`=@subject,`description`=@description,`solution`=@solution,
            `product_id`=@product_id,`service`=@service,`status`=@status,`start`=@start,`end`=@end,
            `active`=@active WHERE `id`=@id";
            TextCommand(sql);
            Parameters("Update");
            return Execute();
        }

        private void Parameters(string action)
        {
            AddParameter("customer_id", this.Customer.ID);
            AddParameter("who_requested", this.WhoRequested);
            AddParameter("user_id", this.User.ID);
            AddParameter("subject", this.Subject);
            AddParameter("description", this.Description);
            AddParameter("solution", this.Solution);
            AddParameter("product_id", this.Product.ID);
            AddParameter("service", this.Service);
            AddParameter("status", this.Status);
            
            if (action == "Insert")
                AddParameter("creation", this.Creation);

            AddParameter("start", this.Start);
            AddParameter("end", this.End);

            if (action == "Update")
            {
                AddParameter("active", this.Active);
                AddParameter("id", this.ID);
            }
        }

        private List<ServiceOrder> TableToList(DataTable table)
        {
            if (table != null)
            {
                List<ServiceOrder> serviceOrders;
                serviceOrders = (from DataRow row in table.AsEnumerable() select new ServiceOrder()
                {
                    ID = Convert.ToInt64(row["id"]),
                    GetCustomer = row["customer_id"],
                    WhoRequested = row["who_requested"].ToString(),
                    GetUser = row["user_id"],
                    Subject = row["subject"].ToString(),
                    Description = row["description"].ToString(),
                    Solution = row["solution"].ToString(),
                    GetProduct = row["product_id"],
                    Service = row["service"].ToString(),
                    Status = row["status"].ToString(),
                    Creation = DateTime.Parse(row["creation"].ToString()),
                    Start = DateTime.Parse(row["start"].ToString()),
                    End = DateTime.Parse(row["end"].ToString()),
                    Active = Convert.ToBoolean(row["active"]),
                }).ToList();
                return serviceOrders;
            }
            return null;
        }

        private object GetCustomer
        {
            set
            {
                if (value is int || value is long)
                {
                    if (Customer.GetByID(Convert.ToInt64(value)))
                        this.Customer = Customer.QueryCustomer;
                }
            }
        }

        private object GetUser
        {
            set
            {
                if (value is int || value is long)
                {
                    if (User.GetByID(Convert.ToInt64(value)))
                        this.User = User.QueryUser;
                }
            }
        }

        private object GetProduct
        {
            set
            {
                if (value is int || value is long)
                {
                    if (Product.GetByID(Convert.ToInt64(value)))
                        this.Product = Product.QueryProduct;
                }
            }
        }
    }
}
