using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (new SplashScreen().ShowDialog() == DialogResult.OK)
            {
                bool exit = false;
                while (!exit)
                {
                    exit = true;
                    if (Module.GetModule(1))
                    {
                        Module module = Module.QueryModule;
                        // User user = ?
                        if (module.Restrict || module.ID == 1)
                        {
                            frmLogin login = new frmLogin(Module.QueryModule);
                            //login.User = user;
                            if (login.ShowDialog() == DialogResult.Yes)
                            {
                                frmHome.User = login.User;
                                if (new frmHome().ShowDialog() == DialogResult.Ignore)
                                    exit = false;
                            }
                        }
                        //else if (!module.Restrict && module.ID != 1)
                        //{
                        //    frmHome.User = login.User;
                        //    if (new frmHome().ShowDialog() == DialogResult.Ignore)
                        //        exit = false;
                        //}
                    }
                }
            }
        }
    }
}
