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
        public long User_ID;
        public long Module_ID;
        public bool HasAccess;

        public bool Save()
        {
            string sql = "UPDATE `access` SET `hasaccess` = @hasaccess WHERE `user` = @user AND `module` = @module";
            TextCommand(sql);
            AddParameter("hasaccess", this.HasAccess);
            AddParameter("user", this.User_ID);
            AddParameter("module", this.Module_ID);

            return Execute();
        }

        public static Access LoadAccess(long user_id, long module_id)
        {
            Access access = new Access();
            string sql = "SELECT * FROM `access` WHERE `user` = @user AND `module` = @module";
            access.TextCommand(sql);
            access.AddParameter("user", user_id);
            access.AddParameter("module", module_id);

            if (access.ExecuteQuery())
            {
                return access.TableToList(Connection.SelectedTable)[0];
            }
            return null;
        }

        private List<Access> TableToList(DataTable table)
        {
            if (table != null)
            {
                List<Access> accesses = new List<Access>();
                accesses = (from DataRow row in table.Rows
                            select new Access()
                            {
                                User_ID = Convert.ToInt64(row["user"]),
                                Module_ID = Convert.ToInt64(row["module"]),
                                HasAccess = Convert.ToBoolean(row["hasaccess"]),
                            }).ToList();
                return accesses;
            }
            return null;
        }
    }
}
