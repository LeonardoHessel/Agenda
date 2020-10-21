using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Customer:Connection
    {
        public long ID;
        public string CNPJ;
        public string IE;
        public string Razao;
        public string Name;
        public string Telephone;
        public string CellPhone;
        public string Email;
        //public Address Address;
        public string Obs;
        public bool Active;

        public static Customer QueryCustomer;
        public static List<Customer> QueryCustomers;

        public bool Insert()
        {
            string sql = @"INSERT INTO `customer` (`cnpj`,`ie`,`razao`,`name`,`telephone`,`cellphone`,`email`,
            `address_id`,`obs`) VALUES (@cnpj,@ir,@razao,@name,@telephone,@cellphone,@email,@address_id,@obs)";
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

        public static bool GetByID(long customer_id)
        {
            Customer customer = new Customer();
            string sql = @"SELECT * FROM `customer` WHERE `id`=@id";
            customer.TextCommand(sql);
            customer.AddParameter("id", customer_id);
            if (customer.ExecuteQuery())
            {
                Customer.QueryCustomer = customer.TableToList(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public static bool SearchAll()
        {
            Customer customer = new Customer();
            string sql = @"SELECT * FROM `customer`";
            customer.TextCommand(sql);
            if (customer.ExecuteQuery())
            {
                Customer.QueryCustomers = customer.TableToList(Connection.SelectedTable);
                return true;
            }
            return false;
        }

        public bool Update()
        {
            string sql = @"UPDATE `serviceorder` SET `customer_id`=@customer_id,`who_requested`=@who_requested,
            `user_id`=@user_id,`subject`=@subject,`description`=@description,`solution`=@solution,
            `service_mode`=@service_mode,`status`=@status,`start`=@start,`end`=@end,
            `active_status`=@active_status WHERE `id`=@id";
            TextCommand(sql);
            Parameters("Update");
            return Execute();
        }

        private void Parameters(string action)
        {
            AddParameter("cnpj", this.CNPJ);
            AddParameter("ie", this.IE);
            AddParameter("razao", this.Razao);
            AddParameter("name", this.Name);
            AddParameter("telephone", this.Telephone);
            AddParameter("cellphone", this.CellPhone);
            AddParameter("email", this.Email);
            //AddParameter("address_id", this.Address.ID);
            AddParameter("obs", this.Obs);

            if (action == "Update")
            {
                AddParameter("active_status", this.ActiveStatus);
                AddParameter("id", this.ID);
            }
        }

        private List<Customer> TableToList(DataTable table)
        {
            if (table != null)
            {
                List<Customer> customers;
                customers = (from DataRow row in table.AsEnumerable()
                                 select new Customer()
                                 {
                                     ID = Convert.ToInt64(row["id"]),
                                     CNPJ = row["cnpj"].ToString(),
                                     IE = row["ie"].ToString(),
                                     Razao = row["razao"].ToString(),
                                     Name = row["name"].ToString(),
                                     Telephone = row["telephone"].ToString(),
                                     CellPhone = row["cellphone"].ToString(),
                                     Email = row["email"].ToString(),
                                     //Address = row["address_id"] is DBNull ? null: Address.GetByID(Convert.ToInt64(row["product_id"])),
                                     Obs = row["obs"].ToString(),
                                 }).ToList();
                return customers;
            }
            return null;
        }
    }
}
