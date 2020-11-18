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
    public partial class frmUser : Form
    {
        public frmUser(Util.ActionMode action, User user = null)
        {
            InitializeComponent();
            this.User = user;
            this.Action = action;
        }

        private Util.ActionMode action;

        public Util.ActionMode Action
        {
            get { return action; }
            set
            {
                action = value;
                SetForm();
            }
        }

        public User User { get; set; }

        private void SetForm()
        {
            if (Action == Util.ActionMode.New)
            {
                this.User = new User();
                this.User.Address = new Address();
                CleanForm();
                cbxIsInactive.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = false;
            }
            else if (Action == Util.ActionMode.Edit)
            {
                ShowObj();
                cbxIsInactive.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void CleanForm()
        {
            txtID.Text = 0.ToString();
            txtName.Text = "";
            cbxIsInactive.Checked = false;
            txtLogin.Text = "";
            txtPassword.Text = "";
            dtpBorn.Value = DateTime.Now;
            cbSex.SelectedIndex = -1;
            txtRG.Text = "";
            txtCPF.Text = "";
            txtCNH.Text = "";
            txtCEP.Text = "";
            txtStreet.Text = "";
            txtNumber.Text = "";
            txtDistrict.Text = "";
            txtCity.Text = "";
            cbState.Text = "SP";
            pbImage.Image = pbImage.InitialImage;
        }

        private void ShowObj()
        {
            txtID.Text = this.User.ID.ToString();
            txtName.Text = this.User.Name;
            cbxIsInactive.Checked = this.User.IsInactive;
            txtLogin.Text = this.User.Login;
            txtPassword.Text = this.User.Password;
            dtpBorn.Value = this.User.Born;
            cbSex.Text = this.User.Sex;
            txtRG.Text = this.User.RG;
            txtCPF.Text = this.User.CPF;
            txtCNH.Text = this.User.CNH;
            if (this.User.Address != null)
            {
                txtCEP.Text = this.User.Address.CEP;
                txtStreet.Text = this.User.Address.Street;
                txtNumber.Text = this.User.Address.Number;
                txtDistrict.Text = this.User.Address.District;
                txtCity.Text = this.User.Address.City;
                cbState.Text = this.User.Address.State;
            }
            else
            {
                AddressIsBlock(true);
            }

            if (this.User.ProfileIMGAddress != null)
            {
                //pbImage.Image = pbImage.InitialImage;
            }
        }

        private void SetObj()
        {
            this.User.Name = txtName.Text;
            this.User.IsInactive = cbxIsInactive.Checked;
            this.User.Login = txtLogin.Text;
            this.User.Password = txtPassword.Text;
            this.User.Born = dtpBorn.Value;
            this.User.Sex = cbSex.Text;
            this.User.RG = rtnNoMask(txtRG);
            this.User.CPF = rtnNoMask(txtCPF);
            this.User.CNH = rtnNoMask(txtCNH);
            if (this.Action == Util.ActionMode.New)
                this.User.Address = new Address();
            this.User.Address.CEP = rtnNoMask(txtCEP);
            this.User.Address.Street = txtStreet.Text;
            this.User.Address.Number = txtNumber.Text;
            this.User.Address.District = txtDistrict.Text;
            this.User.Address.City = txtCity.Text;
            this.User.Address.State = cbState.Text;
            //pbImage.Image = pbImage.InitialImage;
        }

        private void AddressIsBlock(bool set)
        {
            txtCEP.Enabled = set;
            txtStreet.Enabled = set;
            txtNumber.Enabled = set;
            txtDistrict.Enabled = set;
            txtCity.Enabled = set;
            cbState.Enabled = set;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            SetObj();
            if (this.Action == Util.ActionMode.New)
            {
                if (!this.User.LoginExists())
                {
                    if (this.User.Insert())
                    {
                        ShowObj();
                        this.Action = Util.ActionMode.Edit;
                        labSaved.Visible = true;
                        tShowSaved.Enabled = true;
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
                else
                    MessageBox.Show("Já existe um login com esse nome!\nAltere, para realizar o cadastro!");
            }
            else if (this.Action == Util.ActionMode.Edit)
            {
                if (this.User.Update())
                {
                    ShowObj();
                    this.Action = Util.ActionMode.Edit;
                    labSaved.Visible = true;
                    tShowSaved.Enabled = true;
                }
                else
                    MessageBox.Show(Connection.ErrorMessage);
            }
            
            btnSave.Enabled = true;
        }

        private string rtnNoMask(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Action = Util.ActionMode.New;
        }

        private void frmUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }

        private void cbxIsInactive_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = !cbxIsInactive.Checked;
            txtName.Enabled = isEnabled;
            txtLogin.Enabled = isEnabled;
            txtPassword.Enabled = isEnabled;
            dtpBorn.Enabled = isEnabled;
            cbSex.Enabled = isEnabled;
            txtRG.Enabled = isEnabled;
            txtCPF.Enabled = isEnabled;
            txtCNH.Enabled = isEnabled;
            txtCEP.Enabled = isEnabled;
            txtStreet.Enabled = isEnabled;
            txtNumber.Enabled = isEnabled;
            txtDistrict.Enabled = isEnabled;
            txtCity.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
        }

        private void tShowSaved_Tick(object sender, EventArgs e)
        {
            tShowSaved.Enabled = false;
            labSaved.Visible = false;
        }
    }
}
