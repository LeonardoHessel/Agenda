using Agenda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmLogin : Form
    {
        public frmLogin(Module module, User user = null)
        {
            InitializeComponent();
            this.User = user;
            this.Module = module;
        }

        private User user;
        private Module Module { get; set; }

        public User User
        {
            get { return this.user; }
            set 
            {
                if (value != null)
                {
                    this.user = value;
                    if ((cbUser.SelectedItem as User).ID != this.User.ID)
                        cbUser.SelectedItem = this.User;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadUsers();
            if (this.User != null)
                cbUser.SelectedItem = this.User;

            cbUser.Text = Settings.Default.LastLogin;
        }

        private void LoadUsers()
        {
            if (User.GetUsers(Util.ActiveStatus.Active))
                cbUser.DataSource = User.QueryUsers;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.User = cbUser.SelectedItem as User;

            if (this.User.CheckPassword(txtPassword.Text) && this.User.ID != 0)
            {
                if (Access.LoadAccess(this.User.ID, this.Module.ID))
                {
                    if (Access.QueryAccess.HasAccess)
                    {
                        Settings.Default.LastLogin = this.User.Name;
                        Properties.Settings.Default.Save();
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("Este usuário não possui a permissão de acesso!\nTente Realizar o acesso com outro usuário");
                    }
                }
                else
                    MessageBox.Show(Connection.ErrorMessage);
            }
        }
    }
}
