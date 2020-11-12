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
            txtSearch.Focus();
            txtSearch.SelectionStart = 0;
            txtSearch.SelectionLength = txtSearch.Text.Length;
        }

        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Customer = dgvData.CurrentRow.DataBoundItem as Customer;
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomer newCustomer = new frmCustomer(Util.ActionMode.New);
            newCustomer.ShowDialog();
            LoadCustomers();
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
    }
}
