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
                        frmLogin login = new frmLogin(Module.QueryModule);

                        login.Module = Module.QueryModule;
                        if (login.ShowDialog() == DialogResult.Yes)
                        {
                            frmHome.User = login.User;
                            frmHome home = new frmHome();
                            if (home.ShowDialog() == DialogResult.Ignore)
                                exit = false;
                        }
                    }
                }
            }
        }
    }
}
