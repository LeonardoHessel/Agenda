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
    public partial class frmDBConfig : Form
    {
        public frmDBConfig()
        {
            InitializeComponent();
            ShowConfig();
        }

        private void ShowConfig()
        {
            txtServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUser.Text = Properties.Settings.Default.User;
            txtPassword.Text = Properties.Settings.Default.Password;
            txtPort.Text = Properties.Settings.Default.Port;
            //Properties.Settings.Default.Charset;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Port = txtPort.Text;
            Properties.Settings.Default.Charset = "utf8";
            
            Properties.Settings.Default.Save();
            btnClose.PerformClick();
        }
    }
}
