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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
