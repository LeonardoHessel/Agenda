using System;
using System.Collections.Generic;
using System.Drawing;
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
            
            SplashScreen splashScreen = new SplashScreen();
            
            if (splashScreen.ShowDialog() == DialogResult.OK)
            {
                bool exit = false;
                while (!exit)
                {
                    exit = true;

                    frmLogin login = new frmLogin();

                    if (login.ShowDialog() == DialogResult.Yes)
                    {
                        //FormAgenda Agenda = new FormAgenda();
                        //Agenda.Usuario = login.Usuario;
                        //DialogResult respOS = Agenda.ShowDialog();
                        //if (respOS == DialogResult.Ignore)
                        //{
                        //    exit = false;
                        //}
                    }
                }
            }
        }
    }
}
