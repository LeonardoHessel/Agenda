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
        public frmLogin(Module module, object User = null)
        {
            InitializeComponent();
            LoadUsers();
            cbUser.SelectedIndex = 0;
        }

        private User user;
        public Module Module;

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

        }

        private void LoadUsers()
        {
            if (User.GetUsers(Util.ActiveStatus.Active))
            {
                cbUser.DataSource = User.QueryUsers;
            }
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

            if (this.User.CheckPassword(txtPassword.Text))
            {
                if (Access.CheckAccess(this.User.ID, this.Module.ID))
                {
                    if (Access.QueryAccess.HasAccess)
                        this.DialogResult = DialogResult.Yes;
                    //Acesso negado.
                }
                // Erro Conexão
                MessageBox.Show(Connection.ErrorMessage);
            }
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.User = cbUser.SelectedItem as User;
        }
    }
}
