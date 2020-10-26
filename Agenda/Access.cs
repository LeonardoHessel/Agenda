using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Access:Connection
    {
        public long User_ID { set; get; }
        public long Module_ID { set; get; }
        public bool HasAccess { set; get; }

        public static Access QueryAccess;
        public static List<Access> QueryAccesses;

        public static bool LoadAccess(long user_id, long module_id)
        {
            Access access = new Access();
            string sql = "SELECT * FROM `access` WHERE `user_id`=@user_id AND `module_id`=@module_id";
            access.TextCommand(sql);
            access.AddParameter("user_id", user_id);
            access.AddParameter("module_id", module_id);

            if (access.ExecuteQuery())
            {
                Access.QueryAccess = access.TableToList(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public static bool LoadAllFromUser(long user_id)
        {
            Access access = new Access();
            string sql = "SELECT * FROM `access` WHERE `user_id`=@user_id";
            access.TextCommand(sql);
            access.AddParameter("user_id", user_id);

            if (access.ExecuteQuery())
            {
                Access.QueryAccesses = access.TableToList(Connection.SelectedTable);
                return true;
            }
            return false;
        }

        public bool Save()
        {
            string sql = @"UPDATE `access` SET `hasaccess`=@hasaccess 
            WHERE `user_id`=@user_id AND `module_id`=@module_id";
            TextCommand(sql);
            AddParameter("hasaccess", this.HasAccess);
            AddParameter("user_id", this.User_ID);
            AddParameter("module_id", this.Module_ID);

            return Execute();
        }

        private List<Access> TableToList(DataTable table)
        {
            if (table != null)
            {
                List<Access> accesses = new List<Access>();
                accesses = (from DataRow row in table.Rows
                            select new Access()
                            {
                                User_ID = Convert.ToInt64(row["user_id"]),
                                Module_ID = Convert.ToInt64(row["module_id"]),
                                HasAccess = Convert.ToBoolean(row["hasaccess"]),
                            }).ToList();
                return accesses;
            }
            return null;
        }
    }
}
