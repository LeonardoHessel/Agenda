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
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
            LoadUsers();
        }

        private static ucUser instance;

        public static ucUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucUser();
                return instance;
            }
        }

        private void ucUser_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser(Util.ActionMode.New);
            newUser.ShowDialog();
            LoadUsers();
            FormatDataGridView();
        }

        private void EditUser(object sender, EventArgs e)
        {
            User user = dgvData.CurrentRow.DataBoundItem as User;
            frmUser editUser = new frmUser(Util.ActionMode.Edit, user);
            editUser.ShowDialog();
            LoadUsers();
            FormatDataGridView();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadUsers();
            FormatDataGridView();
        }

        private void LoadUsers()
        {
            Util.ActiveStatus status = Util.ActiveStatus.All;
            if (rbActive.Checked)
                status = Util.ActiveStatus.Active;
            else if (rbInactive.Checked)
                status = Util.ActiveStatus.Disabled;

            string search = txtSearch.Text == "" ? null : txtSearch.Text;

            if (User.GetUsers(status, search))
                dgvData.DataSource = User.QueryUsers;
            else
                MessageBox.Show(Connection.ErrorMessage);
        }

        private void FormatDataGridView()
        {
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                bool isInactive = Convert.ToBoolean(row.Cells["colIsInactive"].Value);

                if (isInactive)
                    dgvData.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Gray;
            }
        }
    }
}
