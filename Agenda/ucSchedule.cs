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

        public ucSchedule()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;
            if (User.GetUsers(Util.ActiveStatus.All, null, true))
                cbUser.DataSource = User.QueryUsers;

            cbUser.Text = frmHome.User.Login;
        }

        private bool ready = false;
        private void ucSchedule_Load(object sender, EventArgs e)
        {
            ready = true;
            LoadServiceOrders();
            FormatNumbers(true);
            FormatDataGridView();
            cbxPreViewSO.Checked = Properties.Settings.Default.PreViewSO;
        }

        private void LoadServiceOrders()
        {
            if (ready)
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

                PreViewSO();

                if (cbxPreViewSO.Checked && dgvData.Rows.Count > 0)
                    PreViewSO(dgvData.CurrentRow.DataBoundItem as ServiceOrder);
            }
        }

        private void PreViewSO(ServiceOrder so = null)
        {
            txtDescription.Text = string.Empty;
            txtID.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtSolution.Text = string.Empty;

            if (so != null)
            {
                txtDescription.Text = so.Description;
                txtID.Text = so.ID.ToString();
                txtSubject.Text = so.Subject;
                txtSolution.Text = so.Solution;
            }
        }

        private void FormatDataGridView()
        {
            if (ready)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    int rowIndex = row.Index;
                    string status = row.Cells["colStatus"].Value.ToString();
                    DateTime end = Convert.ToDateTime(row.Cells["colEnd"].Value);
                    int difference = DateTime.Compare(end, DateTime.Now);
                    bool isInactive = Convert.ToBoolean(row.Cells["colIsInactive"].Value);

                    switch (status)
                    {
                        case "Agendado":
                            dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(72, 254, 90);
                            break;
                        case "Finalizado":
                            dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(207, 255, 255);
                            break;
                        case "Pendente":
                            dgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 255, 86);
                            break;
                    }

                    if (difference < 0 && status != "Finalizado")
                    {
                        dgvData.Rows[rowIndex].Cells["colID"].Style.BackColor = Color.FromArgb(255, 102, 102);
                    }

                    if (isInactive)
                        dgvData.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

        private void FormatNumbers(bool setTotal = false)
        {
            if (ready)
            {
                int greenST = 0, blueST = 0, yellowST = 0, redST = 0;

                if (setTotal)
                {
                    var values = ServiceOrder.Count((cbUser.SelectedItem as User).ID);

                    labTGreen.Text = values.schedule.ToString();
                    labTBlue.Text = values.finalized.ToString();
                    labTYellow.Text = values.pending.ToString();
                    labTRed.Text = values.late.ToString();
                    labTAll.Text = values.total.ToString();
                }

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    string status = row.Cells["colStatus"].Value.ToString();
                    DateTime end = Convert.ToDateTime(row.Cells["colEnd"].Value);
                    int difference = DateTime.Compare(end, DateTime.Now);

                    switch (status)
                    {
                        case "Agendado":
                            greenST++;
                            break;
                        case "Finalizado":
                            blueST++;
                            break;
                        case "Pendente":
                            yellowST++;
                            break;
                    }

                    if (difference < 0 && status != "Finalizado")
                        redST++;
                }

                labSTGreen.Text = greenST.ToString();
                labSTBlue.Text = blueST.ToString();
                labSTYellow.Text = yellowST.ToString();
                labSTRed.Text = redST.ToString();
                labSTall.Text = dgvData.RowCount.ToString();
            }
        }

        private void Search_Changed(object sender, EventArgs e)
        {
            LoadServiceOrders();
            FormatDataGridView();
            FormatNumbers(sender.Equals(cbUser));
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void EditServiceOrder(object sender, EventArgs e)
        {
            ServiceOrder serviceOrder = dgvData.CurrentRow.DataBoundItem as ServiceOrder;
            frmServiceOrder editServiceOrder = new frmServiceOrder(Util.ActionMode.Edit, serviceOrder);
            editServiceOrder.ShowDialog();
            LoadServiceOrders();
            FormatDataGridView();
            FormatNumbers(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmServiceOrder newServiceOrder = new frmServiceOrder(Util.ActionMode.New);
            newServiceOrder.ShowDialog();
            LoadServiceOrders();
            FormatDataGridView();
            FormatNumbers(true);
        }

        private void pGreen_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 1;
        }

        private void pBlue_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 2;
        }

        private void pYellow_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 3;
        }

        private void pRed_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 4;
        }

        private void pAll_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 0;
        }

        private void cbxPreViewSO_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PreViewSO = cbxPreViewSO.Checked;
            Properties.Settings.Default.Save();
            flpPreviewSO.Visible = cbxPreViewSO.Checked;

            if (cbxPreViewSO.Checked && dgvData.Rows.Count > 0)
                PreViewSO(dgvData.CurrentRow.DataBoundItem as ServiceOrder);
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (cbxPreViewSO.Checked && dgvData.Rows.Count > 0)
                PreViewSO(dgvData.CurrentRow.DataBoundItem as ServiceOrder);
        }
    }
}
