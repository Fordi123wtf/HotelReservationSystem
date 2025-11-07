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
    public partial class User_MainMenu : Form
    {
        public User_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);    
            if (result == DialogResult.Yes)
            {
                User_Interface1 user_Interface = new User_Interface1();
                user_Interface.Show();
                this.Hide();
            }
            else
            {
                // Do nothing, user canceled log out
            }
        }
    }
}
