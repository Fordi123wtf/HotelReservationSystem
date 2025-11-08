using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewGrid
{
    public partial class USER_BOOKINGCOMPLETE : Form
    {
        public USER_BOOKINGCOMPLETE()
        {
            InitializeComponent();
        }

        private void btnBookAnother_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
