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
        public long ID;
        public Customer Customer;
        public string WhoRequested;
        public User User;
        public string Subject;
        public string Description;
        public string Solution;
        //public Product Product;
        public string ServiceMode;
        public string Status;
        public DateTime Creation;
        public DateTime Start;
        public DateTime End;
        public bool Active;

        public static ServiceOrder QueryServiceOrder;
        public static List<ServiceOrder> QueryServiceOrders;

        public bool Insert()
        {
            string sql = @"INSERT INTO `serviceorder` (`customer_id`,`who_requested`,`user_id`,`subject`,
            `description`,`solution`,`service_mode`,`status`,`creation`,`start`,`end`) VALUES (@customer_id,
            @who_requested,@user_id,@subject,@description,@solution,@service_mode,@status,@creation,@start,@end)";
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
            string sql = @"SELECT * FROM `service_order` WHERE `id`=@id";
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
            string sql = @"SELECT * FROM `service_order`";
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
            `service_mode`=@service_mode,`status`=@status,`start`=@start,`end`=@end,
            `active_status`=@active WHERE `id`=@id";
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
            //AddParameter("product_id", this.Product.ID);
            AddParameter("service_mode", this.ServiceMode);
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
                    GetCustomer = row["customer_id"] is DBNull ? 0 : Convert.ToInt64(row["customer_id"]),
                    WhoRequested = row["who_requested"].ToString(),
                    GetUser = row["user_id"] is DBNull ? 0 : Convert.ToInt64(row["user_id"]),
                    Subject = row["subject"].ToString(),
                    Description = row["description"].ToString(),
                    Solution = row["solution"].ToString(),
                    GetProduct = row["product_id"] is DBNull ? 0 : Convert.ToInt64(row["product_id"]),
                    ServiceMode = row["service_mode"].ToString(),
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

        private long GetCustomer
        {
            set
            {
                if (value != 0)
                {
                    if (Customer.GetByID(value))
                        this.Customer = Customer.QueryCustomer;
                }
            }
        }

        private long GetUser
        {
            set
            {
                if (value != 0)
                {
                    //if (User.GetByID(value))
                    //    this.User = User.QueryUser;
                }
            }
        }

        private long GetProduct
        {
            set
            {
                if (value != 0)
                {
                    //if (Product.GetByID(value))
                    //    this.Product = Product.QueryProduct;
                }
            }
        }
    }
}
