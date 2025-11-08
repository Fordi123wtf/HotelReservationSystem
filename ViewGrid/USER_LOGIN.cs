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
    public partial class USER_LOGIN : Form
    {
        public USER_LOGIN()
        {
            InitializeComponent();
        }

        
        private void btnFinish_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            USER_MainMenu mainMenu = new USER_MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact administrator to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
