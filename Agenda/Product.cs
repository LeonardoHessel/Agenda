using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Product : Connection
    {
        public long ID;
        public string Name;
        public bool Active;

        public static Product QueryProduct;
        public static List<Product> QueryProducts;

        public bool Insert()
        {
            string sql = "INSERT INTP `product` (`name`) VALUES (@name)";
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
            Product product = new Product();
            string sql = @"SELECT * FROM `product` WHERE `id`=@id";
            product.TextCommand(sql);
            product.AddParameter("id", serviceOrder_id);
            if (product.ExecuteQuery())
            {
                Product.QueryProduct = product.TableToList(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public static bool SearchAll(bool addAll = false)
        {
            Product product = new Product();
            string sql = @"SELECT * FROM `product`";
            product.TextCommand(sql);
            if (product.ExecuteQuery())
            {
                Product.QueryProducts = product.TableToList(Connection.SelectedTable);
                return true;
            }
            return false;
        }

        public bool Update()
        {
            string sql = "UPDATE `product` SET `name`=@name,`active`=@active WHERE `id`=@id";
            TextCommand(sql);
            Parameters("Update");
            return Execute();
        }

        private void Parameters(string action)
        {
            AddParameter("customer_id", this.Name);
            if (action == "Update")
            {
                AddParameter("active", this.Active);
                AddParameter("id", this.ID);
            }
        }

        private List<Product> TableToList(DataTable table, bool addAllObj = false)
        {
            if (table != null)
            {
                List<Product> products;
                products = (from DataRow row in table.AsEnumerable()
                            select new Product()
                            {
                                ID = Convert.ToInt64(row["id"]),
                                Name = row["name"].ToString(),
                                Active = Convert.ToBoolean(row["active"]),
                            }).ToList();

                if (addAllObj)
                    products.Add(ProductAll());

                return products;
            }
            return null;
        }

        private Product ProductAll()
        {
            Product product = new Product();
            product.ID = 0;
            product.Name = "Todos";
            return product;
        }
    }
}
