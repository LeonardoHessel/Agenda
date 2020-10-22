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
        public long ID { set; get; }
        public string CNPJ { set; get; }
        public string IE { set; get; }
        public string Razao { set; get; }
        public string Name { set; get; }
        public string Telephone { set; get; }
        public string CellPhone { set; get; }
        public string Email { set; get; }
        public Address Address { set; get; }
        public string Obs { set; get; }
        public bool Active { set; get; }

        public static Customer QueryCustomer { private set; get; }
        public static List<Customer> QueryCustomers { private set; get; }

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
            string sql = @"UPDATE `customer` SET `cnpj`=@cnpj,`ie`=@ie,
            `razao`=@razao,`telephone`=@telephone,`cellphone`=@cellphone,`email`=@email,
            `address_id`=@address_id,`obs`=@obs,`active`=@active WHERE `id`=@id";
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
            AddParameter("address_id", this.Address.ID);
            AddParameter("obs", this.Obs);

            if (action == "Update")
            {
                AddParameter("active", this.Active);
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
                                 GetAddress = row["address_id"],
                                 Obs = row["obs"].ToString(),
                             }).ToList();
                return customers;
            }
            return null;
        }

        private object GetAddress
        {
            set
            {
                if (value is int || value is long)
                {
                    if (Address.GetByID(Convert.ToInt64(value)))
                        this.Address = Address.QueryAddress;
                }
            }
        }
    }
}
