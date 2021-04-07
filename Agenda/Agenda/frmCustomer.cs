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

            if (Product.SearchAll(Util.ActiveStatus.All, null, false, true))
                cbProduct.DataSource = Product.QueryProducts;

            cbState.Text = "SP";
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            SetCustomer();
            if (this.Customer.CNPJ.Length == 14 || cbxInfoPending.Checked)
            {
                if (this.Action == Util.ActionMode.New)
                {
                    if (this.Customer.Insert())
                    {
                        this.Action = Util.ActionMode.Edit;
                        labSaved.Visible = true;
                        tShowSaved.Enabled = true;
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
                else if (this.Action == Util.ActionMode.Edit)
                {
                    if (this.Customer.Update())
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
                MessageBox.Show("CNPJ Inválido");

            btnSave.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Action = Util.ActionMode.New;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowCustomer();
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

        private void cbxIsInactive_CheckedChanged(object sender, EventArgs e)
        {
            SetFieldsAs(!cbxIsInactive.Checked);
        }

        private void btnQueryCEP_Click(object sender, EventArgs e)
        {
            string cep = Util.NoMask(mtbCEP);
            if (!string.IsNullOrWhiteSpace(cep))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(cep.Trim());
                        cbState.Text = endereco.uf;
                        txtCity.Text = endereco.cidade;
                        txtDistrict.Text = endereco.bairro;
                        txtStreet.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void SetCustomer()
        {
            // Customer
            this.Customer.IsInactive = cbxIsInactive.Checked;
            this.Customer.Responsible = txtResponsible.Text;
            this.Customer.Razao = txtRazao.Text;
            this.Customer.Name = txtName.Text;
            this.Customer.CNPJ = Util.NoMask(mtbCNPJ);
            this.Customer.IE = Util.NoMask(mtbIE);
            this.Customer.Prospecting = cbxProspecting.Checked;
            this.Customer.FinancialPending = cbxFinancialPending.Checked;
            this.Customer.InfoPending = cbxInfoPending.Checked;
            this.Customer.Telephone = Util.NoMask(mtbTelephone);
            this.Customer.CellPhone = Util.NoMask(mtbCellphone);
            this.Customer.Since = dtpSince.Value;
            this.Customer.Email = txtEmail.Text;
            this.Customer.Obs = txtObs.Text;
            // Address
            this.Customer.Address.CEP = Util.NoMask(mtbCEP);
            this.Customer.Address.Street = txtStreet.Text;
            this.Customer.Address.Number = txtNumber.Text;
            this.Customer.Address.District = txtDistrict.Text;
            this.Customer.Address.City = txtCity.Text;
            this.Customer.Address.State = cbState.Text;
            // Accountant Office
            this.Customer.Accountant = txtAccountant.Text;
            this.Customer.AccountantEmail = txtAccountantEmail.Text;
            // Product
            this.Customer.Product = cbProduct.SelectedItem as Product;
            this.Customer.Components = txtModule.Text;
            this.Customer.Terminals = Convert.ToInt32(nudTerminals.Value);
        }

        private void ShowCustomer()
        {
            // Customer
            txtID.Text = this.Customer.ID.ToString();
            txtResponsible.Text = this.Customer.Responsible;
            cbxIsInactive.Checked = this.Customer.IsInactive;
            txtRazao.Text = this.Customer.Razao;
            txtName.Text = this.Customer.Name;
            mtbCNPJ.Text = this.Customer.CNPJ;
            mtbIE.Text = this.Customer.IE;
            cbxProspecting.Checked = this.Customer.Prospecting;
            cbxFinancialPending.Checked = this.Customer.FinancialPending;
            cbxInfoPending.Checked = this.Customer.InfoPending;
            mtbTelephone.Text = this.Customer.Telephone;
            mtbCellphone.Text = this.Customer.CellPhone;
            dtpSince.Value = this.Customer.Since;
            txtEmail.Text = this.Customer.Email;
            txtObs.Text = this.Customer.Obs;
            // Address
            mtbCEP.Text = this.Customer.Address.CEP;
            txtStreet.Text = this.Customer.Address.Street;
            txtNumber.Text = this.Customer.Address.Number;
            txtDistrict.Text = this.Customer.Address.District;
            txtCity.Text = this.Customer.Address.City;
            cbState.Text = this.Customer.Address.State;
            // Accountant Office
            txtAccountant.Text = this.Customer.Accountant;
            txtAccountantEmail.Text = this.Customer.AccountantEmail;
            // Product
            cbProduct.Text = this.Customer.Product != null ? this.Customer.Product.Name : "Nenhum";
            txtModule.Text = this.Customer.Components;
            nudTerminals.Value = this.Customer.Terminals;
        }

        private void SetFieldsAs(bool setAs)
        {
            // Customer
            txtRazao.Enabled = setAs;
            txtResponsible.Enabled = setAs;
            txtName.Enabled = setAs;
            mtbCNPJ.Enabled = setAs;
            mtbIE.Enabled = setAs;
            mtbTelephone.Enabled = setAs;
            cbxProspecting.Enabled = setAs;
            cbxFinancialPending.Enabled = setAs;
            cbxInfoPending.Enabled = setAs;
            mtbCellphone.Enabled = setAs;
            dtpSince.Enabled = setAs;
            txtEmail.Enabled = setAs;
            txtObs.Enabled = setAs;
            // Address
            mtbCEP.Enabled = setAs;
            txtStreet.Enabled = setAs;
            txtNumber.Enabled = setAs;
            txtDistrict.Enabled = setAs;
            txtCity.Enabled = setAs;
            cbState.Enabled = setAs;
            // Accountant Office
            txtAccountant.Enabled = setAs;
            txtAccountantEmail.Enabled = setAs;
            // Product
            cbProduct.Enabled = setAs;
            txtModule.Enabled = setAs;
            nudTerminals.Enabled = setAs;
        }

        private void CleanForm()
        {
            // Customer
            txtID.Text = 0.ToString();
            cbxIsInactive.Checked = false;
            txtResponsible.Text = "";
            txtRazao.Text = "";
            txtName.Text = "";
            mtbCNPJ.Text = "";
            mtbIE.Text = "";
            cbxProspecting.Checked = false;
            cbxFinancialPending.Checked = false;
            cbxInfoPending.Checked = false;
            mtbTelephone.Text = "";
            mtbCellphone.Text = "";
            dtpSince.Value = DateTime.Now;
            txtEmail.Text = "";
            txtObs.Text = "";
            // Adddress
            mtbCEP.Text = "";
            txtStreet.Text = "";
            txtNumber.Text = "";
            txtDistrict.Text = "";
            txtCity.Text = "";
            cbState.Text = "";
            // Accountant Office
            txtAccountant.Text = "";
            txtAccountantEmail.Text = "";
            // Product
            cbProduct.SelectedIndex = 0;
            txtModule.Text = "";
            nudTerminals.Value = 0;
        }

        private void tShowSaved_Tick(object sender, EventArgs e)
        {
            tShowSaved.Enabled = false;
            labSaved.Visible = false;
        }

        private void mtbCNPJ_Validated(object sender, EventArgs e)
        {
            if (this.Action == Util.ActionMode.New && !cbxInfoPending.Checked)
            {
                string cnpj = Util.NoMask(mtbCNPJ);

                if (cnpj.Length >= 14)
                {
                    if (Customer.GetByCNPJ(cnpj))
                    {
                        if (Customer.QueryCustomers.Count > 0)
                        {
                            MessageBox.Show("CNPJ já cadastrado", "Aviso CNPJ");
                            mtbCNPJ.Text = "";
                        }
                    }
                    else
                        MessageBox.Show(Connection.ErrorMessage);
                }
            }
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
    }
}
