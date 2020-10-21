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
    public partial class frmServiceOrder : Form
    {
        public frmServiceOrder(Util.ActionMode action)
        {
            InitializeComponent();
            this.Action = action;
        }

        private void frmServiceOrder_Load(object sender, EventArgs e)
        {
            cbUser.DataSource = User.GetUsers(Util.ActiveStatus.Active,null,true);
            
            ////cbProduct.SelectedItem = 
            //cbServiceMode.SelectedIndex = 3;
            //cbStatus.SelectedIndex = 3;
        }

        private Util.ActionMode action;

        public ServiceOrder ServiceOrder;

        private Util.ActionMode Action
        {
            get { return this.action; }
            set 
            {
                this.action = value;
                ResetForm();
            }
        }


        private void ResetForm()
        {
            if (this.Action == Util.ActionMode.New)
            {
                this.ServiceOrder = new ServiceOrder();
                btnEdit.Enabled = false;
                btnSave.Enabled = true;
            }
            else if (this.Action == Util.ActionMode.Edit)
            {
                ShowServiceOrder();
                
            }
        }

        private void ShowServiceOrder()
        {
            txtServiceOrderID.Text = this.ServiceOrder.ID.ToString();
            //txtCustomer.Text = this.ServiceOrder.Customer.Razao;
            //txtCustomerCNPJ.Text = this.ServiceOrder.Customer.CNPJ;
            txtWhoRequested.Text = this.ServiceOrder.WhoRequested;
            cbUser.SelectedItem = this.ServiceOrder.User;
            txtSubject.Text = this.ServiceOrder.Subject;
            txtDescription.Text = this.ServiceOrder.Description;
            txtSolution.Text = this.ServiceOrder.Solution;
            //cbProduct.SelectedItem = this.ServiceOrder.Product;
            cbServiceMode.Text = this.ServiceOrder.ServiceMode;
            cbStatus.Text = this.ServiceOrder.Status;
            if (!this.ServiceOrder.ActiveStatus)
            {
                cbServiceOrderInactive.Checked = true;
            }
        }

        private void cbServiceOrderInactive_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !cbServiceOrderInactive.Checked;
            txtCustomer.Enabled = enabled;
            btnSearchCustomer.Enabled = enabled;
            txtWhoRequested.Enabled = enabled;
            cbUser.Enabled = enabled;
            txtSubject.Enabled = enabled;
            txtDescription.Enabled = enabled;
            txtSolution.Enabled = enabled;
            cbProduct.Enabled = enabled;
            cbServiceMode.Enabled = enabled;
            cbStatus.Enabled = enabled;
            dtpServiceStartDate.Enabled = enabled;
            dtpServiceEndDate.Enabled = enabled;
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchCustomer.PerformClick();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string search = txtCustomer.Text;

            MessageBox.Show(search);
            //if (nameof != null)
            //{
            //    //this.ServiceOrder.Customer = 
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
