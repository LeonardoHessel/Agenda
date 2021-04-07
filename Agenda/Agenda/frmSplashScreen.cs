using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            ShowCompany();
        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                tToClose.Stop();
                frmDBConfig dbConfig = new frmDBConfig();
                dbConfig.ShowDialog();
                tToClose.Start();
            }
        }

        private void tToClose_Tick(object sender, EventArgs e)
        {
            tToClose.Stop();
            if (Connection.ConnectionTest())
                this.DialogResult = DialogResult.OK;
            else
            {
                DialogResult result = MessageBox.Show("Falha ao acessar o banco de dados!", "Conexão", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                    this.DialogResult = DialogResult.Abort;
            }
            tToClose.Start();
        }

        private void ShowCompany()
        {
            // Carregar e exibir os dados da empresa.
        }
    }
}
