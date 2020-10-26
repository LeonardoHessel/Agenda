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
        public long ID { set; get; }
        public string Name { set; get; }
        public bool IsInactive { set; get; }

        public static Product QueryProduct { private set; get; }
        public static List<Product> QueryProducts { private set; get; }

        public bool Insert()
        {
            string sql = "INSERT INTO `product` (`name`) VALUES (@name)";
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

        public static bool SearchAll(Util.ActiveStatus status, string search = null, bool addAll = false)
        {
            Product product = new Product();
            string addSQL = " WHERE ";
            string sql = @"SELECT * FROM `product`";

            if (status != Util.ActiveStatus.All)
            {
                sql += addSQL + "`is_inactive`=@is_inactive";
                addSQL = " AND ";
            }

            if (search != null)
                sql += addSQL + "(`name` LIKE CONCAT('%',@search,'%'))";

            product.TextCommand(sql);

            if (status == Util.ActiveStatus.Active)
                product.AddParameter("is_inactive", false);
            else if (status == Util.ActiveStatus.Disabled)
                product.AddParameter("is_inactive", true);

            if (search != null)
                product.AddParameter("search", search);

            if (product.ExecuteQuery())
            {
                Product.QueryProducts = product.TableToList(Connection.SelectedTable,addAll);
                return true;
            }
            return false;
        }

        public bool Update()
        {
            string sql = "UPDATE `product` SET `name`=@name,`is_inactive`=@is_inactive WHERE `id`=@id";
            TextCommand(sql);
            Parameters("Update");
            return Execute();
        }

        private void Parameters(string action)
        {
            AddParameter("name", this.Name);
            if (action == "Update")
            {
                AddParameter("is_inactive", this.IsInactive);
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
                                IsInactive = Convert.ToBoolean(row["is_inactive"]),
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
            product.IsInactive = false;
            return product;
        }
    }
}
