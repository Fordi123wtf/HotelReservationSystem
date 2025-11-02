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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
            admin_DashBoard.Show();
            this.Hide();

        }
    }
}
