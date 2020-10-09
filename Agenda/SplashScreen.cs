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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                tToClose.Stop();
                MessageBox.Show("Teste");
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

        private void LoadCompany()
        {
            // Carregar e exibir os dados da empresa.
        }
    }
}
