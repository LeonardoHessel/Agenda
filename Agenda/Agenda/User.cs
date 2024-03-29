﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class User:Connection
    {
        public long ID { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public DateTime Born { set; get; }
        public string Sex { set; get; }
        public string CPF { set; get; }
        public string RG { set; get; }
        public string CNH { set; get; }
        public string ProfileIMGAddress { set; get; }
        public Address Address { set; get; }
        public bool IsInactive { set; get; }

        public static User QueryUser { private set; get; }
        public static List<User> QueryUsers { private set; get; }

        public bool Insert()
        {
            if (this.Address.Insert())
            {
                string sql = @"INSERT INTO `user` (`login`,`password`,`name`,`born`,`sex`,`cpf`,`rg`,`cnh`,
                `profile_img_address`,`address_id`) VALUES (@login,@password,@name,@born,@sex,@rg,@cpf,@cnh,
                @profile_img_address,@address_id)";
                TextCommand(sql);
                Parameters("Insert");
                if (Execute())
                {
                    this.ID = Connection.LastInsertID;
                    this.IsInactive = false;
                    return true;
                }
            }
            return false;
        }

        public bool LoginExists()
        {
            string sql = "SELECT * FROM `user` WHERE `login` = @login";
            TextCommand(sql);
            AddParameter("login", this.Login);
            if (ExecuteQuery())
            {
                List<User> userList = TableToLst(Connection.SelectedTable);
                return userList.Count > 0;
            }                
            return true;
        }

        public static bool GetByID(long user_id)
        {
            User user = new User();
            string sql = "SELECT * FROM `user` WHERE `id`=@id";
            user.TextCommand(sql);
            user.AddParameter("id", user_id);
            if (user.ExecuteQuery())
            {
                User.QueryUser = user.TableToLst(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public static bool GetUsers(Util.ActiveStatus status, string search = null, bool addAllObj = false)
        {
            User user = new User();
            string addSql = " WHERE ";

            string sql = "SELECT * FROM `user`";

            if (status != Util.ActiveStatus.All)
            {
                sql += addSql + "`is_inactive` = @is_inactive";
                addSql = " AND ";
            }

            if (search != null)
            {
                sql += addSql + @"(`name` LIKE CONCAT('%', @search,'%') OR 
                `login` LIKE CONCAT('%', @search,'%') OR 
                `born` LIKE CONCAT('%', @search,'%') OR 
                `rg` LIKE CONCAT('%', @search,'%') OR 
                `cpf` LIKE CONCAT('%', @search,'%') OR 
                `cnh` LIKE CONCAT('%', @search,'%'))";
            }

            user.TextCommand(sql);

            if (search != null)
                user.AddParameter("search", search);

            if (status == Util.ActiveStatus.Active)
                user.AddParameter("is_inactive", false);
            else if (status == Util.ActiveStatus.Disabled)
                user.AddParameter("is_inactive", true);

            if (user.ExecuteQuery())
            {
                User.QueryUsers = user.TableToLst(Connection.SelectedTable,addAllObj);
                return true;
            }
            return false;
        }

        public bool Update()
        {

            if (this.Address.Update())
            {
                string sql = @"UPDATE `user` SET `login`=@login,`password`=@password,`name`=@name,
                `born`=@born,`sex`=@sex,`cpf`=@cpf,`rg`=@rg,`cnh`=@cnh,
                `profile_img_address`=@profile_img_address,`address_id`=@address_id,`is_inactive`=@is_inactive
                WHERE `id`=@id";
                TextCommand(sql);
                Parameters("Update");
                return Execute();
            }
            return false;
        }

        private void Parameters(string action)
        {
            AddParameter("login", this.Login);
            AddParameter("password", this.Password);
            AddParameter("name", this.Name);
            AddParameter("born", this.Born);
            AddParameter("sex", this.Sex);
            AddParameter("cpf", this.CPF);
            AddParameter("rg", this.RG);
            AddParameter("cnh", this.CNH);
            AddParameter("profile_img_address", this.ProfileIMGAddress);
            AddParameter("address_id", this.Address.ID);

            if (action == "Update")
            {
                AddParameter("is_inactive", this.IsInactive);
                AddParameter("id", this.ID);
            }
        }

        private List<User> TableToLst(DataTable table, bool addAllObj = false)
        {
            List<User> users = new List<User>();
            if (table != null)
            {
                users = (from DataRow row in table.AsEnumerable()
                         select new User()
                         {
                             ID = Convert.ToInt64(row["id"]),
                             Login = row["login"].ToString(),
                             Password = row["password"].ToString(),
                             Name = row["name"].ToString(),
                             Born = Convert.ToDateTime(row["born"]),
                             Sex = row["sex"].ToString(),
                             RG = row["rg"].ToString(),
                             CPF = row["cpf"].ToString(),
                             CNH = row["cnh"].ToString(),
                             ProfileIMGAddress = row["profile_img_address"].ToString(),
                             GetAddress = row["address_id"],
                             IsInactive = Convert.ToBoolean(row["is_inactive"]),
                         }).ToList<User>();

                if (addAllObj)
                    users.Insert(0, UserALL());

                return users;
            }
            return null;
        }

        private User UserALL()
        {
            User user = new User();
            user.ID = 0;
            user.Login = "Todos";
            user.Password = "123";
            user.Name = "Todos";
            return user;
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

        public bool CheckPassword(string password)
        {
            return this.Password == password;
        }
    }
}
