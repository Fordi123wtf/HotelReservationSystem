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
    public partial class ClientRecords : Form
    {
        public ClientRecords()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRdashboard_Click(object sender, EventArgs e)
        {
            Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
            admin_DashBoard.Show();
            this.Hide();
        }
    }
}
