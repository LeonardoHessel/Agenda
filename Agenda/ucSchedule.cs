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
    public partial class ucSchedule : UserControl
    {
        public ucSchedule()
        {
            InitializeComponent();
            LoadSchedule();
        }

        private static ucSchedule instance;

        public static ucSchedule Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucSchedule();
                return instance;
            }
        }

        private void ucSchedule_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 0;
            if (User.GetUsers(Util.ActiveStatus.All, null, true))
                cbUser.DataSource = User.QueryUsers;
            FormatDataGridView();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmServiceOrder newServiceOrder = new frmServiceOrder(Util.ActionMode.New);
            newServiceOrder.ShowDialog();
            LoadSchedule();
            FormatDataGridView();
        }

        private void EditServiceOrder(object sender, EventArgs e)
        {
            ServiceOrder serviceOrder = dgvData.CurrentRow.DataBoundItem as ServiceOrder;
            frmServiceOrder editServiceOrder = new frmServiceOrder(Util.ActionMode.Edit, serviceOrder);
            editServiceOrder.ShowDialog();
            LoadSchedule();
            FormatDataGridView();
        }

        private void Search_Changed(object sender, EventArgs e)
        {
            LoadSchedule();
            FormatDataGridView();
        }

        private void LoadSchedule()
        {
            string status = "Todos";
            long user_id = 0;
            DateTime afD, beD;

            if (cbStatus.Text != null)
                status = cbStatus.Text;

            if (cbUser.SelectedItem != null)
                user_id = (cbUser.SelectedItem as User).ID;

            afD = dtpAfter.Value;
            beD = dtpBefore.Value;

            if (ServiceOrder.SearchAll(afD, beD, dtpAfter.Checked, dtpBefore.Checked, txtSearch.Text, status, user_id))
                dgvData.DataSource = ServiceOrder.QueryServiceOrders;
            else
                MessageBox.Show(Connection.ErrorMessage);
        }

        private void FormatDataGridView()
        {
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                DataGridViewCell cell = row.Cells["colStatus"];
                int rowIndex = row.Index;

                switch (cell.Value.ToString())
                {
                    case "Agendado":
                        dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(86, 164, 255);
                        break;
                    case "Cancelado":
                        dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 86, 86);
                        break;
                    case "Finalizado":
                        dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(72, 254, 90);
                        break;
                    case "Pendente":
                        dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 255, 86);
                        break;
                    default:
                        break;
                }

                bool isInactive = Convert.ToBoolean(row.Cells["colIsInactive"].Value);

                if (isInactive)
                    dgvData.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Gray;
            }
        }
    }
}
