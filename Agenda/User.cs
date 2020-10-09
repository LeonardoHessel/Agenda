using System;
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
        public long ID;
        public string Login;
        private string Password;
        public string Name;
        public DateTime BornDate;
        public string Sex;
        public string RG;
        public string CPF;
        public string CNH;
        public string ProfileIMGAddress;
        public bool Active;

        public static List<User> GetUsers(Util.ActiveStatus status, string search = null, bool addAllObj = false)
        {
            User user = new User();
            string addSql = " WHERE ";
            string sql = @"SELECT * FROM `user`";
            if (search != null)
            {
                sql += addSql + "(`name` LIKE (%, @search,%))";
                addSql = " AND ";
            }
            if (status != Util.ActiveStatus.All)
            {
                sql += addSql + "`active` = @active";
                addSql = " AND ";
            }

            user.TextCommand(sql);
            if (search != null)
                user.AddParameter("search", search);
            if (status == Util.ActiveStatus.Active)
                user.AddParameter("active", true);
            else if (status == Util.ActiveStatus.Disabled)
                user.AddParameter("active", false);

            if (user.ExecuteQuery())
            {
                return user.TableToLst(Connection.SelectedTable,addAllObj);
            }

            return null;
        }

        public bool CheckPassword(string password)
        {
            return this.Password == password;
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
                             BornDate = Convert.ToDateTime(row["borndate"]),
                             Sex = row["sex"].ToString(),
                             RG = row["rg"].ToString(),
                             CPF = row["cpf"].ToString(),
                             CNH = row["cnh"].ToString(),
                             ProfileIMGAddress = row["profileimgaddress"].ToString(),
                             Active = Convert.ToBoolean(row["active"]),
                         }).ToList<User>();

                if (addAllObj)
                {
                    users.Add(UserALL());
                }
                return users;
            }
            return null;
        }

        private User UserALL()
        {
            User user = new User();
            user.ID = 0;
            user.Name = "Todos";
            return user;
        }
    }
}
