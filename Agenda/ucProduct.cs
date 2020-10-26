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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        private static ucProduct instance;

        public static ucProduct Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucProduct();
                return instance;
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void LoadProducts()
        {
            Util.ActiveStatus status = Util.ActiveStatus.All;
            if (rbActive.Checked)
                status = Util.ActiveStatus.Active;
            else if (rbInactive.Checked)
                status = Util.ActiveStatus.Disabled;

            string search = txtSearch.Text == "" ? null : txtSearch.Text;

            if (Product.SearchAll(status, search))
                dgvData.DataSource = Product.QueryProducts;
            else
                MessageBox.Show(Connection.ErrorMessage);
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
