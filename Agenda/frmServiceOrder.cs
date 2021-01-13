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
        private Util.ActionMode Action { get; set; }
        
        private Customer customer;
        
        private Customer Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                if (customer != null)
                {
                    txtCustomer.Text = customer.Razao;
                    txtCustomerCNPJ.Text = customer.CNPJ;
                }
            }
        }
        
        public ServiceOrder ServiceOrder { get; set; }

        public frmServiceOrder(Util.ActionMode action, ServiceOrder serviceOrder = null)
        {
            InitializeComponent();
            LoadComponentData();

            this.ServiceOrder = serviceOrder;
            this.Action = action;
        }
        
        private void frmServiceOrder_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void cbServiceOrderInactive_CheckedChanged(object sender, EventArgs e)
        {
            bool setAs = !cbServiceOrderInactive.Checked;
            EnableDisabledFields(setAs);
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
                if (this.Customer.FinancialPending)
                {
                    MessageBox.Show("Este cliente possui pendência financeira.\nSolicite que ele entre em contato com o setor Finaceiro", "Pendência");
                    this.Customer = null;
                }
                else if (this.Customer.Product != null)
                {
                    DialogResult result = MessageBox.Show("Deseja aplicar o produto: " + this.Customer.Product.Name + ", a Ordem de Serviço?","Aplicar Produto", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        cbProduct.Text = this.Customer.Product.Name;
                }

                if (this.Customer != null)
                    MessageBox.Show("Observações do Cliente:\n" + this.Customer.Obs);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct newProduct = new frmProduct(Util.ActionMode.New);
            newProduct.ShowDialog();

            if (Product.SearchAll(Util.ActiveStatus.All, null, false, true))
                cbProduct.DataSource = Product.QueryProducts;
        }

        private void frmServiceOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Action = Util.ActionMode.New;

            ResetFields();
            SetForm();
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
                        SetForm();
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
                else
                {
                    if (this.ServiceOrder.Update())
                    {
                        this.Action = Util.ActionMode.Edit;
                        labSaved.Visible = true;
                        tShowSaved.Enabled = true;
                        SetForm();
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("Para criar uma nova ordem de serviço é necessário que um cliente seja selecionado");
            }
            if (this.ServiceOrder.Status == "Finalizado")
                btnSave.Enabled = true;
        }

        private void tShowSaved_Tick(object sender, EventArgs e)
        {
            tShowSaved.Enabled = false;
            labSaved.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowServiceOrder();
        }

        // Functions/Methods

        private void LoadComponentData()
        {
            Util.ActiveStatus status = Util.ActiveStatus.All;
            if (this.Action == Util.ActionMode.New)
                status = Util.ActiveStatus.Active;

            if (User.GetUsers(status))
                cbUser.DataSource = User.QueryUsers;

            if (User.GetUsers(status))
                cbWhoLaunched.DataSource = User.QueryUsers;

            if (Product.SearchAll(status, null, false, true))
                cbProduct.DataSource = Product.QueryProducts;
        }

        private void SetForm()
        {
            if (this.Action == Util.ActionMode.New)
            {
                this.ServiceOrder = new ServiceOrder();
                DefaultValues();
                btnSave.Enabled = true;
                btnCancel.Enabled = false;
                cbServiceOrderInactive.Enabled = false;
            }
            else if (this.Action == Util.ActionMode.Edit)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                cbServiceOrderInactive.Enabled = true;
                ShowServiceOrder();
                if (this.ServiceOrder.Status == "Finalizado")
                {
                    EnableDisabledFields(false);
                    cbServiceOrderInactive.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                }
            }
        }

        private void DefaultValues()
        {
            cbUser.Text = frmHome.User.Name;
            cbWhoLaunched.Text = frmHome.User.Name;
            cbServiceMode.SelectedIndex = 3;
            cbStatus.SelectedIndex = 3;
            
        }

        private void ShowServiceOrder()
        {
            ServiceOrder SO = this.ServiceOrder;
            //
            cbServiceOrderInactive.Checked = SO.IsInactive;
            txtServiceOrderID.Text = SO.ID.ToString();
            this.Customer = SO.Customer;
            txtWhoRequested.Text = SO.WhoRequested;
            //
            if (SO.WhoLaunched != null)
                cbWhoLaunched.Text = SO.WhoLaunched.Name;
            if (SO.User != null)
                cbUser.Text = SO.User.Name;
            //
            txtSubject.Text = SO.Subject;
            txtDescription.Text = SO.Description;
            txtSolution.Text = SO.Solution;

            if (SO.Product != null)
                cbProduct.Text = SO.Product.Name;

            cbServiceMode.Text = SO.Service;
            cbStatus.Text = SO.Status;
            //
            dtpServiceCreationDate.Value = SO.Creation;
            dtpServiceStartDate.Value = SO.Start;
            dtpServiceEndDate.Value = SO.End;
        }

        private void SetServiceOrder()
        {
            this.ServiceOrder.Customer = this.Customer;
            this.ServiceOrder.IsInactive = cbServiceOrderInactive.Checked;
            this.ServiceOrder.WhoRequested = txtWhoRequested.Text;
            //
            this.ServiceOrder.WhoLaunched = cbWhoLaunched.SelectedItem as User;
            this.ServiceOrder.User = cbUser.SelectedItem as User;
            //
            this.ServiceOrder.Subject = txtSubject.Text;
            this.ServiceOrder.Description = txtDescription.Text;
            this.ServiceOrder.Solution = txtSolution.Text;
            //
            this.ServiceOrder.Product = cbProduct.SelectedItem as Product;
            this.ServiceOrder.Service = cbServiceMode.Text;
            this.ServiceOrder.Status = cbStatus.Text;
            //
            this.ServiceOrder.Creation = dtpServiceCreationDate.Value;
            this.ServiceOrder.Start = dtpServiceStartDate.Value;
            this.ServiceOrder.End = dtpServiceEndDate.Value;
        }

        private void EnableDisabledFields(bool setAs)
        {
            txtCustomer.Enabled = setAs;
            btnSearchCustomer.Enabled = setAs;
            txtWhoRequested.Enabled = setAs;
            //
            cbUser.Enabled = setAs;
            //
            txtSubject.Enabled = setAs;
            txtDescription.Enabled = setAs;
            txtSolution.Enabled = setAs;
            //
            cbProduct.Enabled = setAs;
            cbServiceMode.Enabled = setAs;
            cbStatus.Enabled = setAs;
            //
            dtpServiceStartDate.Enabled = setAs;
            dtpServiceEndDate.Enabled = setAs;
        }

        private void ResetFields()
        {
            this.Customer = null;
            txtServiceOrderID.Text = "0";
            cbServiceOrderInactive.Checked = false;
            //
            txtCustomer.Text = "";
            txtCustomerCNPJ.Text = "";
            txtWhoRequested.Text = "";
            //
            cbWhoLaunched.SelectedItem = frmHome.User;
            cbUser.SelectedItem = frmHome.User;
            //
            txtSubject.Text = "";
            txtDescription.Text = "";
            txtSolution.Text = "";
            //
            cbProduct.SelectedIndex = 0;
            cbServiceMode.SelectedIndex = 3;
            cbStatus.SelectedIndex = 3;
            //
            dtpServiceCreationDate.Value = DateTime.Now;
            dtpServiceStartDate.Value = DateTime.Now;
            dtpServiceEndDate.Value = DateTime.Now;
            EnableDisabledFields(true);
        }

        // Move Form START
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void labTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // Move Form END

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //foreach (Form frm in Application.OpenForms)
            //{
            //    frm.WindowState = FormWindowState.Minimized;
            //}
        }
    }
}
