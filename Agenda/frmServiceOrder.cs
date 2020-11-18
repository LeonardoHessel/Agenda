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
        public frmServiceOrder(Util.ActionMode action, ServiceOrder serviceOrder = null)
        {
            InitializeComponent();
            this.ServiceOrder = serviceOrder;
            this.Action = action;
        }

        private void frmServiceOrder_Load(object sender, EventArgs e)
        {
            if (User.GetUsers(Util.ActiveStatus.All))
                cbUser.DataSource = User.QueryUsers;

            if (Product.SearchAll(Util.ActiveStatus.All, null, false, true))
                cbProduct.DataSource = Product.QueryProducts;

            if (this.Action == Util.ActionMode.New)
            {
                cbUser.Text = frmHome.User.Name;
                cbServiceMode.SelectedIndex = 3;
                cbStatus.SelectedIndex = 3;
            }
            else
            {
                if (this.ServiceOrder.User != null)
                    cbUser.Text = this.ServiceOrder.User.Name;

                if (this.ServiceOrder.Product != null)
                    cbProduct.Text = this.ServiceOrder.Product.Name;
            }
        }

        private Util.ActionMode action;
        private Customer customer;
        
        private Util.ActionMode Action
        {
            get { return this.action; }
            set 
            {
                this.action = value;
                SetForm();
            }
        }

        private Customer Customer
        {
            get { return this.customer; }
            set
            {
                this.customer = value;
                txtCustomer.Text = this.customer.Razao;
                txtCustomerCNPJ.Text = this.customer.CNPJ;
            }
        }

        public ServiceOrder ServiceOrder { get; set; }

        private void SetForm()
        {
            if (this.Action == Util.ActionMode.New)
            {
                this.ServiceOrder = new ServiceOrder();
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
            this.Customer = this.ServiceOrder.Customer;
            txtWhoRequested.Text = this.ServiceOrder.WhoRequested;

            cbUser.SelectedItem = this.ServiceOrder.User;
            
            txtSubject.Text = this.ServiceOrder.Subject;
            txtDescription.Text = this.ServiceOrder.Description;
            txtSolution.Text = this.ServiceOrder.Solution;
            
            if (this.ServiceOrder.Product != null)

            cbProduct.Text = this.ServiceOrder.Product.Name;

            cbServiceMode.Text = this.ServiceOrder.Service;
            cbStatus.Text = this.ServiceOrder.Status;
            cbServiceOrderInactive.Checked = this.ServiceOrder.IsInactive;
            dtpServiceCreationDate.Value = this.ServiceOrder.Creation;
            dtpServiceStartDate.Value = this.ServiceOrder.Start;
            dtpServiceEndDate.Value = this.ServiceOrder.End;
        }

        private void SetServiceOrder()
        {
            this.ServiceOrder.Customer = this.Customer;
            this.ServiceOrder.IsInactive = cbServiceOrderInactive.Checked;
            this.ServiceOrder.WhoRequested = txtWhoRequested.Text;
            this.ServiceOrder.User = cbUser.SelectedItem as User;
            this.ServiceOrder.Subject = txtSubject.Text;
            this.ServiceOrder.Description = txtDescription.Text;
            this.ServiceOrder.Solution = txtSolution.Text;
            this.ServiceOrder.Product = cbProduct.SelectedItem as Product;
            this.ServiceOrder.Service = cbServiceMode.Text;
            this.ServiceOrder.Status = cbStatus.Text;
            this.ServiceOrder.Creation = dtpServiceCreationDate.Value;
            this.ServiceOrder.Start = dtpServiceStartDate.Value;
            this.ServiceOrder.End = dtpServiceEndDate.Value;
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

            frmSearchCustomer searchCustomer = new frmSearchCustomer(search);
            if (searchCustomer.ShowDialog() == DialogResult.Yes)
            {
                this.Customer = searchCustomer.Customer;
                if (this.Customer.Product != null)
                {
                    DialogResult result = MessageBox.Show("Deseja aplicar o produto: " + this.Customer.Product.Name + ", a Ordem de Serviço?","Aplicar Produto", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        cbProduct.Text = this.Customer.Product.Name;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            SetServiceOrder();
            if (this.ServiceOrder.Customer != null)
            {
                if (this.Action == Util.ActionMode.New)
                {
                    if (this.ServiceOrder.Insert())
                    {
                        ShowServiceOrder();
                        this.Action = Util.ActionMode.Edit;
                        labSaved.Visible = true;
                        tShowSaved.Enabled = true;
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
                else if (this.Action == Util.ActionMode.Edit)
                {
                    if (this.ServiceOrder.Update())
                    {
                        this.Action = Util.ActionMode.Edit;
                        labSaved.Visible = true;
                        tShowSaved.Enabled = true;
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("Para criar uma nova ordem de serviço é necessário que um cliente seja selecionado");
            }
            btnSave.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Action = Util.ActionMode.New;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowServiceOrder();
        }

        private void frmServiceOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbProduct.Text = this.ServiceOrder.Product.Name;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct newProduct = new frmProduct(Util.ActionMode.New);
            newProduct.ShowDialog();

            if (Product.SearchAll(Util.ActiveStatus.All, null, false, true))
                cbProduct.DataSource = Product.QueryProducts;
        }

        private void tShowSaved_Tick(object sender, EventArgs e)
        {
            tShowSaved.Enabled = false;
            labSaved.Visible = false;
        }
    }
}
