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
        public frmCustomer(Util.ActionMode action, Customer customer)
        {
            InitializeComponent();
            this.Customer = customer;
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

        public Customer Customer { get; set; }

        private void SetForm()
        {
            if (Action == Util.ActionMode.New)
            {
                this.Customer = new Customer();
                CleanForm();
                cbxIsInactive.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = false;
            }
            else if (Action == Util.ActionMode.Edit)
            {
                ShowProduct();
                cbxIsInactive.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void CleanForm()
        {
            txtID.Text = 0.ToString();
            txtName.Enabled = false;
            cbxIsInactive.Checked = false;
        }

        private void ShowProduct()
        {
            txtID.Text = this.Customer.ID.ToString();
            //cbxIsInactive.Checked = this.Customer.IsInactive;
            txtRazao.Text = this.Customer.Razao;
            txtName.Text = this.Customer.Name;
            txtCNPJ.Text = this.Customer.CNPJ;
            txtIE.Text = this.Customer.IE;
            txtTelephone.Text = this.Customer.Telephone;
            txtCellphone.Text = this.Customer.CellPhone;
            txtEmail.Text = this.Customer.Email;
            txtObs.Text = this.Customer.Obs;
            txtAccountant.Text = this.Customer.Accountant;
            txtAccountantEmail.Text = this.Customer.AccountantEmail;
            //txtModule.Text = this.Customer
            if (this.Customer.Product != null)
            {

            }
            if (this.Customer.Address != null)
            {
                txtCEP.Text = this.Customer.Address.CEP;
                txtStreet.Text = this.Customer.Address.Street;
                txtNumber.Text = this.Customer.Address.Number;
                txtDistrict.Text = this.Customer.Address.District;
                txtCity.Text = this.Customer.Address.City;
                txtState.Text = this.Customer.Address.State;
            }
            else
            {
                //AddressIsBlock(true);
            }
        }

        private void SetProduct()
        {
            
        }
    }
}
