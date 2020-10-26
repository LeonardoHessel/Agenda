﻿using System;
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
        public string Obs { set; get; }
        public Address Address { set; get; }
        public string Accountant { set; get; }
        public string AccountantEmail { set; get; }
        public Product Product { set; get; }
        public string Components { set; get; }
        public bool Active { set; get; }

        public static Customer QueryCustomer { private set; get; }
        public static List<Customer> QueryCustomers { private set; get; }

        public bool Insert()
        {
            string sql = @"INSERT INTO `customer` (`cnpj`,`ie`,`razao`,`name`,`telephone`,`cellphone`,`email`,`obs`,
            `address_id`,`accountant`,`accountant_email`,`product_id`,`components`) VALUES (@cnpj,@ie,@razao,@name,
            @telephone,@cellphone,@email,@obs,@address_id,@accountant,@accountant_email,@product_id,@components)";
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
            string sql = @"UPDATE `customer` SET `cnpj`=@cnpj,`ie`=@ie,`razao`=@razao,`telephone`=@telephone,
            `cellphone`=@cellphone,`email`=@email,`obs`=@obs,`address_id`=@address_id,`accountant`=@accountant,
            `accountant_email`=@accountant_email,`product_id`=@product_id,`components`=@components,
            `active`=@active WHERE `id`=@id";
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
            AddParameter("obs", this.Obs);
            AddParameter("address_id", this.Address.ID);
            AddParameter("accountant", this.Accountant);
            AddParameter("accountant_email", this.AccountantEmail);
            AddParameter("product_id", this.Product.ID);
            AddParameter("components", this.Components);

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
                                 Obs = row["obs"].ToString(),
                                 GetAddress = row["address_id"],
                                 Accountant = row["accountant"].ToString(),
                                 AccountantEmail = row["accountant_email"].ToString(),
                                 GetProduct = row["product_id"],
                                 Components = row["components"].ToString(),
                                 Active = Convert.ToBoolean(row["active"]),
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