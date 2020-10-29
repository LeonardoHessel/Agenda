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
    public partial class frmProduct : Form
    {
        public frmProduct(Util.ActionMode action, Product product = null)
        {
            InitializeComponent();

            this.Product = product;
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

        public Product Product { get; set; }

        private void SetForm()
        {
            if (Action == Util.ActionMode.New)
            {
                this.Product = new Product();
                CleanForm();
                cbxInactive.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = false;
            }
            else if (Action == Util.ActionMode.Edit)
            {
                ShowProduct();
                cbxInactive.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void CleanForm()
        {
            txtID.Text = 0.ToString();
            txtName.Text = "";
            cbxInactive.Checked = false;
        }

        private void ShowProduct()
        {
            txtID.Text = this.Product.ID.ToString();
            txtName.Text = this.Product.Name;
            cbxInactive.Checked = this.Product.IsInactive;
        }

        private void SetProduct()
        {
            this.Product.Name = txtName.Text;
            this.Product.IsInactive = cbxInactive.Checked;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            if (this.Action != Util.ActionMode.New)
                this.Action = Util.ActionMode.New;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            SetProduct();
            if (this.Action == Util.ActionMode.New)
            {
                if (this.Product.Insert())
                {
                    ShowProduct();
                    this.Action = Util.ActionMode.Edit;
                }
                else
                    MessageBox.Show(Connection.ErrorMessage);
            }
            else if (this.Action == Util.ActionMode.Edit)
            {
                if (!this.Product.Update())
                    MessageBox.Show(Connection.ErrorMessage);
            }
            btnSave.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnSave.PerformClick();
            }
        }
    }
}
