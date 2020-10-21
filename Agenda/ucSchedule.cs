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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
