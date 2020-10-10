using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Module:Connection
    {
        public long ID;
        public string Name;
        public bool Restrict;

        public static Module GetModule(long module_id)
        {
            Module module = new Module();
            string sql = "SELECT * FROM `module` WHERE `id` = @id";
            module.TextCommand(sql);
            module.AddParameter("id", module_id);

            if (module.ExecuteQuery())
            {
                return module.TableToList(Connection.SelectedTable)[0];
            }
            return null;
        }

        public static List<Module> GetModules()
        {
            Module module = new Module();
            string sql = "SELECT * FROM `module`";
            module.TextCommand(sql);

            if (module.ExecuteQuery())
            {
                return module.TableToList(Connection.SelectedTable);
            }
            return null;
        }
        
        public bool Save()
        {
            string sql = "UPDATE `module` SET `name` = @name, `restrict` = @restrict WHERE `id` = @id";
        }

        private List<Module> TableToList(DataTable table)
        {
            if (table != null)
            {
                List<Module> modules = new List<Module>();
                modules = (from DataRow row in table.AsEnumerable()
                           select new Module()
                           {
                               ID = Convert.ToInt64(row["id"]),
                               Name = row["name"].ToString(),
                               Restrict = Convert.ToBoolean(row["restrict"]),
                           }).ToList();
                return modules;
            }
            return null;
        }
    }
}
