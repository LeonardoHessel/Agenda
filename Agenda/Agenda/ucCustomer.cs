using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class ucCustomer : UserControl
    {
        private static ucCustomer instance;

        public static ucCustomer Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucCustomer();
                return instance;
            }
        }

        public ucCustomer()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }        

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
            FormatNumbers(true);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomer newCustomer = new frmCustomer(Util.ActionMode.New);
            newCustomer.ShowDialog();
            LoadCustomers();
            FormatDataGridView();
            FormatNumbers(true);
        }

        private void EditCustomer(object sender, EventArgs e)
        {
            Customer customer = dgvData.CurrentRow.DataBoundItem as Customer;
            frmCustomer editCustomer = new frmCustomer(Util.ActionMode.Edit, customer);
            editCustomer.ShowDialog();
            LoadCustomers();
            FormatDataGridView();
            FormatNumbers(true);
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            LoadCustomers();
            FormatDataGridView();
            FormatNumbers(false);
        }

        private void LoadCustomers()
        {
            Util.ActiveStatus status = Util.ActiveStatus.All;
            if (rbActive.Checked)
                status = Util.ActiveStatus.Active;
            else if (rbInactive.Checked)
                status = Util.ActiveStatus.Disabled;

            string type = cbFilter.Text;

            string search = txtSearch.Text == "" ? null : txtSearch.Text;

            if (Customer.SearchAll(status, search, type))
                dgvData.DataSource = Customer.QueryCustomers;
            else
                MessageBox.Show(Connection.ErrorMessage);
            FormatNumbers();
        }

        private void FormatDataGridView()
        {
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                bool isInactive = Convert.ToBoolean(row.Cells["colIsInactive"].Value);
                bool isProspecting = Convert.ToBoolean(row.Cells["colProspecting"].Value);
                bool isfinancialPending = Convert.ToBoolean(row.Cells["colFinancialPending"].Value);

                if (isInactive)
                    dgvData.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Gray;

                if (isProspecting)
                    dgvData.Rows[row.Index].DefaultCellStyle.BackColor = Color.FromArgb(252, 255, 86);

                if (isfinancialPending)
                    dgvData.Rows[row.Index].DefaultCellStyle.BackColor = Color.FromArgb(255, 86, 86);
            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 3;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 2;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 1;
        }

        private void All_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void FormatNumbers(bool setTotal = false)
        {
            int greenT = 0, blueT = 0, yellowT = 0, redT = 0;
            int greenST = 0, blueST = 0, yellowST = 0, redST = 0;

            List<Customer> customers = new List<Customer>();

            if (setTotal)
            {
                if (Customer.SearchAll(Util.ActiveStatus.All))
                {
                    customers = Customer.QueryCustomers;

                    foreach (Customer customer in customers)
                    {
                        if (customer.FinancialPending)
                            redT++;

                        if (customer.Prospecting)
                            yellowT++;

                        if (customer.InfoPending)
                            blueT++;
                    }

                    labTBlue.Text = blueT.ToString();
                    labTYellow.Text = yellowT.ToString();
                    labTRed.Text = redT.ToString();
                    labTAll.Text = customers.Count.ToString();
                }
            }

            customers = dgvData.DataSource as List<Customer>;

            foreach (Customer customer in customers)
            {
                if (customer.FinancialPending)
                    redST++;

                if (customer.Prospecting)
                    yellowST++;

                if (customer.InfoPending)
                    blueST++;
            }

            labSTBlue.Text = blueST.ToString();
            labSTYellow.Text = yellowST.ToString();
            labSTRed.Text = redST.ToString();
            labSTall.Text = dgvData.RowCount.ToString();
        }
    }
}
