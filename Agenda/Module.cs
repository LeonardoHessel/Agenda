using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Module:Connection
    {
        public long ID { set; get; }
        public string Name { set; get; }
        public bool Restrict { set; get; }

        public static Module QueryModule { get; set; }
        public static List<Module> QueryModules { get; set; }

        public static bool GetModule(long module_id)
        {
            Module module = new Module();
            string sql = "SELECT * FROM `module` WHERE `id` = @id";
            module.TextCommand(sql);
            module.AddParameter("id", module_id);

            if (module.ExecuteQuery())
            {
                Module.QueryModule = module.TableToList(Connection.SelectedTable)[0];
                return true;
            }
            return false;
        }

        public static bool GetModules()
        {
            Module module = new Module();
            string sql = "SELECT * FROM `module`";
            module.TextCommand(sql);

            if (module.ExecuteQuery())
            {
                Module.QueryModules = module.TableToList(Connection.SelectedTable);
                return true;
            }
            return false;
        }
        
        public bool Save()
        {
            string sql = "UPDATE `module` SET `name` = @name, `restrict` = @restrict WHERE `id` = @id";
            TextCommand(sql);
            AddParameter("name", this.Name);
            AddParameter("restrict", this.Restrict);
            AddParameter("id", this.ID);
            return Execute();
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
