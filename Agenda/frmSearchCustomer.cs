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
    public partial class frmSearchCustomer : Form
    {
        public frmSearchCustomer(string search = null)
        {
            InitializeComponent();
            txtSearch.Text = search;
            LoadCustomers();
        }

        public Customer Customer { set; get; }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
            txtSearch.Focus();
            txtSearch.SelectionStart = 0;
            txtSearch.SelectionLength = txtSearch.Text.Length;
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            LoadCustomers();
            FormatDataGridView();
        }

        private void SelectCustomer(object sender, EventArgs e)
        {
            this.Customer = dgvData.CurrentRow.DataBoundItem as Customer;
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomer newCustomer = new frmCustomer(Util.ActionMode.New);
            newCustomer.ShowDialog();
            LoadCustomers();
            FormatDataGridView();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Customer = dgvData.CurrentRow.DataBoundItem as Customer;
            this.DialogResult = DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomers()
        {
            Util.ActiveStatus status = Util.ActiveStatus.All;
            if (rbActive.Checked)
                status = Util.ActiveStatus.Active;
            else if (rbInactive.Checked)
                status = Util.ActiveStatus.Disabled;

            string search = txtSearch.Text == "" ? null : txtSearch.Text;

            if (Customer.SearchAll(status, search))
                dgvData.DataSource = Customer.QueryCustomers;
            else
                MessageBox.Show(Connection.ErrorMessage);
        }

        private void frmSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvData.Rows.Count > 0)
            {
                btnSelect.PerformClick();
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                dgvData.Select();
            }
        }

        private void dgvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSelect.PerformClick();
        }
    }
}
