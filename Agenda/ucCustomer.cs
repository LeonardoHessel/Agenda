﻿using System;
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
            cbFilter.SelectedIndex = 0;
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

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
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
        }

        private void EditCustomer(object sender, EventArgs e)
        {
            Customer customer = dgvData.CurrentRow.DataBoundItem as Customer;
            frmCustomer editCustomer = new frmCustomer(Util.ActionMode.Edit, customer);
            editCustomer.ShowDialog();
            LoadCustomers();
            FormatDataGridView();
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            LoadCustomers();
            FormatDataGridView();
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
            LoadCustomers();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 2;
            LoadCustomers();
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 1;
            LoadCustomers();
        }

        private void All_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            LoadCustomers();
        }
    }
}
