using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public class ServiceOrder : Connection
    {
        public long ID { set; get; }
        public Customer Customer { set; get; }
        public string WhoRequested { set; get; }
        public User WhoLaunched { get; set; }
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
        public bool IsInactive { set; get; }

        public String CustomerRazao { get { return Customer != null ? Customer.Razao : null; } }
        public String CustomerCNPJ { get { return Customer != null ? Customer.CNPJ : null; } }
        public String CustomerComponents { get { return Customer != null ? Customer.Components : null; } }
        public string UserName { get { return User != null ? User.Name : null; } }
        public string ProductName { get { return Product != null ? Product.Name : null; } }

        public static ServiceOrder QueryServiceOrder { private set; get; }
        public static List<ServiceOrder> QueryServiceOrders { private set; get; }

        public bool Insert()
        {
            string sql = @"INSERT INTO `serviceorder` (`customer_id`,`whorequested`,`launched_id`,`user_id`,`subject`,
            `description`,`solution`,`product_id`,`service`,`status`,`creation`,`start`,`end`) 
            VALUES (@customer_id,@whorequested,@launched_id,@user_id,@subject,@description,@solution,@product_id,
            @service,@status,@creation,@start,@end)";
            TextCommand(sql);
            Parameters("Insert");
            if (Execute())
            {
                this.ID = Connection.LastInsertID;
                this.IsInactive = false;
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

        public static bool SearchAll(DateTime afDate, DateTime beDate, bool afBool, bool beBool, 
            string search = null, string status = "Todos", long user_id = 0)
        {
            afDate = afDate.Subtract(afDate.TimeOfDay);
            beDate = beDate.Subtract(beDate.TimeOfDay);
            beDate = beDate.AddDays(1);
            ServiceOrder order = new ServiceOrder();
            string addSql = " WHERE ";
            string sql = @"SELECT `so`.* FROM `serviceorder` `so`
            JOIN `customer` `c` ON `c`.`id` = `so`.`customer_id`";
            if (afBool && status != "Atrasado")
            {
                sql += addSql + "`so`.`start` >= @afDate";
                addSql = " AND ";
            }

            if (beBool && status != "Atrasado")
            {
                sql += addSql + "`so`.`start` < @beDate";
                addSql = " AND ";
            }

            if (status == "Atrasado")
            {
                sql += addSql + "`so`.`end` < @late";
                addSql = " AND ";
            }

            if (search != null && search != "")
            {
                sql += addSql + @"(`c`.`responsible` LIKE CONCAT('%', @search,'%') OR
                `so`.`subject` LIKE CONCAT('%', @search,'%') OR 
                `so`.`description` LIKE CONCAT('%', @search,'%') OR 
                `c`.`razao` LIKE CONCAT('%', @search,'%') OR 
                `c`.`name` LIKE CONCAT('%', @search,'%') OR 
                `so`.`solution` LIKE CONCAT('%', @search,'%'))";
                addSql = " AND ";
            }

            if (status != "Todos" && status != "")
            {
                if (status == "Atrasado")
                    sql += addSql + "`status` <> 'Finalizado'";
                else
                    sql += addSql + "`status` = @status";
                addSql = " AND ";
            }

            if (user_id != 0)
            {
                sql += addSql + "`user_id` = @user_id";
                addSql = " AND ";
            }

            sql += " ORDER BY `start` DESC";

            order.TextCommand(sql);

            if (afBool)
                order.AddParameter("afDate", afDate);

            if (beBool)
                order.AddParameter("beDate", beDate);
            
            if (status == "Atrasado")
                order.AddParameter("late", DateTime.Now);

            if (search != null && search != "")
                order.AddParameter("search", search);

            if (status != "Todos" && status != "")
                order.AddParameter("status", status);

            if (user_id != 0)
                order.AddParameter("user_id", user_id);

            if (order.ExecuteQuery())
            {
                ServiceOrder.QueryServiceOrders = order.TableToList(Connection.SelectedTable);
                return true;
            }
            return false;
        }

        public static (long finalized, long pending, long late, long schedule, long total) Count(long user_id = 0)
        {
            ServiceOrder conn = new ServiceOrder();
            string sql;

            if (user_id == 0)
            {
                sql = @"SELECT
                (SELECT COUNT(*) FROM `serviceorder` WHERE `status` = 'Finalizado') AS 'Finalized', 
                (SELECT COUNT(*) FROM `serviceorder` WHERE `status` = 'Pendente') AS 'Pending', 
                (SELECT COUNT(*) FROM `serviceorder` WHERE `status` <> 'Finalizado' AND `end` < NOW()) AS 'Late', 
                (SELECT COUNT(*) FROM `serviceorder` WHERE `status` = 'Agendado') AS 'Scheduled', 
                (SELECT COUNT(*) FROM `serviceorder`) as 'Total'";
            }
            else
            {
                sql = @"SELECT
                (SELECT COUNT(*) FROM serviceorder WHERE `status` = 'Finalizado' AND `user_id` = @user_id) AS 'Finalized', 
                (SELECT COUNT(*) FROM serviceorder WHERE `status` = 'Pendente' AND `user_id` = @user_id) AS 'Pending', 
                (SELECT COUNT(*) FROM serviceorder WHERE `status` <> 'Finalizado' AND `end` < NOW() AND `user_id` = @user_id) AS 'Late', 
                (SELECT COUNT(*) FROM serviceorder WHERE `status` = 'Agendado' AND `user_id` = @user_id) AS 'Scheduled', 
                (SELECT COUNT(*) FROM serviceorder WHERE `user_id` = @user_id) as 'Total'";
            }

            conn.TextCommand(sql);

            if (user_id != 0)
                conn.AddParameter("user_id",user_id);

            if (conn.ExecuteQuery())
            {
                DataTable table = Connection.SelectedTable;

                long finalized = table.Rows[0].Field<long>("Finalized");
                long pending = table.Rows[0].Field<long>("Pending");
                long late = table.Rows[0].Field<long>("Late");
                long schedule = table.Rows[0].Field<long>("Scheduled");
                long total = table.Rows[0].Field<long>("Total");
                
                return (finalized, pending, late, schedule, total);
            }
            return (0, 0, 0, 0, 0);
        }

        public bool Update()
        {
            string sql = @"UPDATE `serviceorder` SET `customer_id`=@customer_id,`whorequested`=@whorequested,
            `user_id`=@user_id,`subject`=@subject,`description`=@description,`solution`=@solution,
            `product_id`=@product_id,`service`=@service,`status`=@status,`start`=@start,`end`=@end,
            `is_inactive`=@is_inactive WHERE `id`=@id";
            TextCommand(sql);
            Parameters("Update");
            return Execute();
        }

        private void Parameters(string action)
        {
            AddParameter("customer_id", this.Customer.ID);
            AddParameter("whorequested", this.WhoRequested);

            if (action == "Insert")
                AddParameter("launched_id", this.WhoLaunched.ID);

            if (this.User != null && this.User.ID > 0)
                AddParameter("user_id", this.User.ID);
            else
                AddParameter("user_id", null);

            AddParameter("subject", this.Subject);
            AddParameter("description", this.Description);
            AddParameter("solution", this.Solution);
            
            if (this.Product != null && this.Product.ID > 0)
                AddParameter("product_id", this.Product.ID);
            else
                AddParameter("product_id", null);

            AddParameter("service", this.Service);
            AddParameter("status", this.Status);
            
            if (action == "Insert")
                AddParameter("creation", this.Creation);

            AddParameter("start", this.Start);
            AddParameter("end", this.End);

            if (action == "Update")
            {
                AddParameter("is_inactive", this.IsInactive);
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
                    WhoRequested = row["whorequested"].ToString(),
                    GetLauncher = row["launched_id"],
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
                    IsInactive = Convert.ToBoolean(row["is_inactive"]),
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

        private object GetLauncher
        {
            set
            {
                if (value is int || value is long)
                {
                    if (User.GetByID(Convert.ToInt64(value)))
                        this.WhoLaunched = User.QueryUser;
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
