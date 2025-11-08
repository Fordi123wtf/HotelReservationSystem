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
    public partial class USER_ROOMTYPES : Form
    {
        public USER_ROOMTYPES()
        {
            InitializeComponent();
        }

        
        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        
        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                USER_ROOMTYPES loginForm = new USER_ROOMTYPES();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
