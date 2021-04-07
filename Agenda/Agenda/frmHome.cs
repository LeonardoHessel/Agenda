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
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        public static User User;

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            labUserName.Text = frmHome.User.Name;
            if (Properties.Settings.Default.SmallMenu)
                btnHideMenu.PerformClick();
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
            else
            {
                labTitle.Visible = false;
                btnNewOS.BackColor = Color.FromArgb(2, 104, 120);
                btnSchedule.BackColor = Color.FromArgb(2, 104, 120);
                btnCustomer.BackColor = Color.FromArgb(2, 104, 120);
                btnUser.BackColor = Color.FromArgb(2, 104, 120);
                btnProduct.BackColor = Color.FromArgb(2, 104, 120);
                pSlide.Visible = false;
                btnReturn.Visible = false;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            labTitle.Text = "Clientes";
            labTitle.Visible = true;
            SetSlide(sender as Button);
            HideAllAndShowUserControl(ucCustomer.Instance);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            labTitle.Text = "Agenda";
            labTitle.Visible = true;
            SetSlide(sender as Button);
            HideAllAndShowUserControl(ucSchedule.Instance);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            labTitle.Text = "Usuários";
            labTitle.Visible = true;
            SetSlide(sender as Button);
            HideAllAndShowUserControl(ucUser.Instance);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            labTitle.Text = "Produtos";
            labTitle.Visible = true;
            SetSlide(sender as Button);
            HideAllAndShowUserControl(ucProduct.Instance);
        }

        private void pbLogoHome_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl();
            pSlide.Visible = false;
            btnReturn.Visible = false;
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
            labTitle.Text = "Nova Ordem de Serviço";
            labTitle.Visible = true;
            SetSlide(btnNewOS);
            frmServiceOrder newServiceOrder = new frmServiceOrder(Util.ActionMode.New);
            newServiceOrder.ShowDialog();
            btnSchedule.PerformClick();
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                int amountOfVisibleUserControl = 0;
                foreach (object obj in pForm.Controls)
                {
                    if (obj is UserControl)
                    {
                        if ((obj as UserControl).Visible == true)
                            amountOfVisibleUserControl++;
                    }
                }

                if (amountOfVisibleUserControl > 0)
                    HideAllAndShowUserControl();
                else
                    btnClose.PerformClick();
                pSlide.Visible = false;
                btnReturn.Visible = false;
            }
        }

        private void pbLogoHome_Resize(object sender, EventArgs e)
        {
            pbLogoHome.Size = new Size(pbLogoHome.Width, pbLogoHome.Width);
        }

        private void btnHideMenu_Click(object sender, EventArgs e)
        {
            if (pMenu.Width == 60)
            {
                pMenu.Width = 180;
                btnHideMenu.Image = Properties.Resources.double_arrow_left_32px;
                
                btnNewOS.Text = "Nova OS";
                btnSchedule.Text = "Agenda";
                btnCustomer.Text = "Clientes";
                btnUser.Text = "Técnicos";
                btnProduct.Text = "Produtos";
                
                labWelcome.Visible = true;
                labUserName.Visible = true;
                Properties.Settings.Default.SmallMenu = false;
            }
            else
            {
                pMenu.Width = 60;
                btnHideMenu.Image = Properties.Resources.double_arrow_rigth_32px;
                
                btnNewOS.Text = string.Empty;
                btnSchedule.Text = string.Empty;
                btnCustomer.Text = string.Empty;
                btnUser.Text = string.Empty;
                btnProduct.Text = string.Empty;

                labWelcome.Visible = false;
                labUserName.Visible = false;
                Properties.Settings.Default.SmallMenu = true;
            }
            Properties.Settings.Default.Save();
        }

        private void SetSlide(Button button)
        {
            pSlide.Location = button.Location;
            pSlide.Visible = true;
            btnReturn.Visible = true;

            btnNewOS.BackColor = Color.FromArgb(2, 104, 120);
            btnSchedule.BackColor = Color.FromArgb(2, 104, 120);
            btnCustomer.BackColor = Color.FromArgb(2, 104, 120);
            btnUser.BackColor = Color.FromArgb(2, 104, 120);
            btnProduct.BackColor = Color.FromArgb(2, 104, 120);

            button.BackColor = Color.FromArgb(2, 80, 92);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            HideAllAndShowUserControl();
        }
    }
}
