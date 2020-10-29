using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Address : Connection
    {
        public long ID { set; get; }
        public string CEP { set; get; }
        public string Street { set; get; }
        public string Number { set; get; }
        public string District { set; get; }
        public string City { set; get; }
        public string State { set; get; }

        public static Address QueryAddress { private set; get; }
        public static List<Address> QueryAddresses { private set; get; }

        public bool Insert()
        {
            string sql = @"INSERT INTO `address` (`cep`,`street`,`number`,`district`,`city`,`state`) 
            VALUES (@cep,@street,@number,@district,@city,@state)";
            TextCommand(sql);
            Parameters("Insert");
            if (Execute())
            {
                this.ID = Connection.LastInsertID;
                return true;
            }
            return false;
        }

        public static bool GetByID(long address_id)
        {
            Address address = new Address();
            string sql = "SELECT * FROM `address` WHERE `id`=@id";
            address.TextCommand(sql);
            address.AddParameter("id", address_id);
            if (address.ExecuteQuery())
            {
                Address.QueryAddress = address.TableToList(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public bool Update()
        {
            string sql = @"UPDATE `address` SET `cep`=@cep,`street`=@street,`number`=@number,`district`=@district,
            `city`=@city,`state`=@state WHERE `id`=@id";
            TextCommand(sql);
            Parameters("Update");
            return Execute();
        }

        private void Parameters(string action)
        {
            AddParameter("cep", this.CEP);
            AddParameter("street", this.Street);
            AddParameter("number", this.Number);
            AddParameter("district", this.District);
            AddParameter("city", this.City);
            AddParameter("state", this.State);
            if (action == "Update")
            {
                AddParameter("id", this.ID);
            }
        }

        private List<Address> TableToList(DataTable table)
        {
            if (table != null)
            {
                List<Address> addresses;
                addresses = (from DataRow row in table.AsEnumerable()
                             select new Address()
                             {
                                 ID = Convert.ToInt64(row["id"]),
                                 CEP = row["cep"].ToString(),
                                 Street = row["street"].ToString(),
                                 Number = row["number"].ToString(),
                                 District = row["district"].ToString(),
                                 City = row["city"].ToString(),
                                 State = row["state"].ToString(),
                             }).ToList();
                return addresses;
            }
            return null;
        }
    }
}
