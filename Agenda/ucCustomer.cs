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
        public ucCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }

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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomer newCustomer = new frmCustomer(Util.ActionMode.New);
            newCustomer.ShowDialog();
            LoadCustomers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer customer = dgvData.CurrentRow.DataBoundItem as Customer;
            frmCustomer editCustomer = new frmCustomer(Util.ActionMode.Edit, customer);
            editCustomer.ShowDialog();
            LoadCustomers();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = dgvData.CurrentRow.DataBoundItem as Customer;
            frmCustomer editCustomer = new frmCustomer(Util.ActionMode.Edit, customer);
            editCustomer.ShowDialog();
            LoadCustomers();
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
