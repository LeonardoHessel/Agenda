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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public static User User;

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void HideAllAndShowUserControl(UserControl userControl = null)
        {
            foreach (var obj in pForm.Controls)
            {
                if (obj is UserControl)
                    (obj as UserControl).Visible = false;
            }
            if (userControl != null)
            {
                if (!pForm.Controls.Contains(userControl))
                    pForm.Controls.Add(userControl);
                userControl.Visible = true;
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl(ucCustomer.Instance);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl(ucSchedule.Instance);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl(ucUser.Instance);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl(ucProduct.Instance);
        }

        private void pbLogoHome_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fazer o logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Ignore;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tMoment_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnNewOS_Click(object sender, EventArgs e)
        {
            frmServiceOrder newServiceOrder = new frmServiceOrder(Util.ActionMode.New);
            newServiceOrder.ShowDialog();
        }
    }
}
