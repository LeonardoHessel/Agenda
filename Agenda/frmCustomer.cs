using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmCustomer : Form
    {
        public frmCustomer(Util.ActionMode action, Customer customer = null)
        {
            InitializeComponent();
            if (Product.SearchAll(Util.ActiveStatus.Active, null, false, true))
                cbProduct.DataSource = Product.QueryProducts;
            this.Customer = customer;
            this.Action = action;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //if (Product.SearchAll(Util.ActiveStatus.Active, null, false, true))
            //    cbProduct.DataSource = Product.QueryProducts;
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

        public Customer Customer { get; set; }

        private void SetForm()
        {
            
            if (Action == Util.ActionMode.New)
            {
                this.Customer = new Customer();
                this.Customer.Address = new Address();
                CleanForm();
                cbxIsInactive.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = false;
            }
            else if (Action == Util.ActionMode.Edit)
            {
                ShowCustomer();
                cbxIsInactive.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void CleanForm()
        {
            txtID.Text = 0.ToString();
            cbxIsInactive.Checked = false;
            txtRazao.Text = "";
            txtName.Text = "";
            txtCNPJ.Text = "";
            txtIE.Text = "";
            txtTelephone.Text = "";
            txtCellphone.Text = "";
            txtEmail.Text = "";
            txtObs.Text = "";
            txtAccountant.Text = "";
            txtAccountantEmail.Text = "";
            cbProduct.SelectedIndex = 0;
            txtModule.Text = "";
            txtCEP.Text = "";
            txtStreet.Text = "";
            txtNumber.Text = "";
            txtDistrict.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
        }

        private void ShowCustomer()
        {
            txtID.Text = this.Customer.ID.ToString();
            cbxIsInactive.Checked = this.Customer.IsInactive;
            txtRazao.Text = this.Customer.Razao;
            txtName.Text = this.Customer.Name;
            txtCNPJ.Text = this.Customer.CNPJ;
            txtIE.Text = this.Customer.IE;
            txtTelephone.Text = this.Customer.Telephone;
            txtCellphone.Text = this.Customer.CellPhone;
            txtEmail.Text = this.Customer.Email;
            txtObs.Text = this.Customer.Obs;

            txtCEP.Text = this.Customer.Address.CEP;
            txtStreet.Text = this.Customer.Address.Street;
            txtNumber.Text = this.Customer.Address.Number;
            txtDistrict.Text = this.Customer.Address.District;
            txtCity.Text = this.Customer.Address.City;
            txtState.Text = this.Customer.Address.State;

            txtAccountant.Text = this.Customer.Accountant;
            txtAccountantEmail.Text = this.Customer.AccountantEmail;

            if (this.Customer.Product != null)
            {
                cbProduct.SelectedItem = this.Customer.Product;
            }
            
            txtModule.Text = this.Customer.Components;
        }

        private void SetCustomer()
        {
            this.Customer.IsInactive = cbxIsInactive.Checked;
            this.Customer.Razao = txtRazao.Text;
            this.Customer.Name = txtName.Text;
            this.Customer.CNPJ = rtnNoMask(txtCNPJ);
            this.Customer.IE = rtnNoMask(txtIE);
            this.Customer.Telephone = txtTelephone.Text;
            this.Customer.CellPhone = txtCellphone.Text;
            this.Customer.Email = txtEmail.Text;
            this.Customer.Obs = txtObs.Text;

            this.Customer.Address.CEP = rtnNoMask(txtCEP);
            this.Customer.Address.Street = txtStreet.Text;
            this.Customer.Address.Number = txtNumber.Text;
            this.Customer.Address.District = txtDistrict.Text;
            this.Customer.Address.City = txtCity.Text;
            this.Customer.Address.State = txtState.Text;

            this.Customer.Accountant = txtAccountant.Text;
            this.Customer.AccountantEmail = txtAccountantEmail.Text;

            this.Customer.Product = cbProduct.SelectedItem as Product;
            this.Customer.Components = txtModule.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            SetCustomer();
            if (this.Action == Util.ActionMode.New)
            {
                if (this.Customer.Address.Insert())
                {
                    if (this.Customer.Insert())
                    {
                        this.Action = Util.ActionMode.Edit;
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
                else
                    MessageBox.Show(Connection.ErrorMessage);
            }
            else if (this.Action == Util.ActionMode.Edit)
            {
                if (this.Customer.Address.Update())
                {
                    if (this.Customer.Update())
                    {
                        this.Action = Util.ActionMode.Edit;
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
                else
                    MessageBox.Show(Connection.ErrorMessage);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Action = Util.ActionMode.New;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private string rtnNoMask(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnClose.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                btnSave.PerformClick();
        }
    }
}
