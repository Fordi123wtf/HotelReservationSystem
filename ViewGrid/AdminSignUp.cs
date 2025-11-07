using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ViewGrid
{
    
    public partial class AdminSignUp : Form
    {
        private cls_admin currentAdmin;
        public AdminSignUp(cls_admin currentAdmin)
        {
            InitializeComponent();

           this.currentAdmin = currentAdmin;

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            cls_admin admin = new cls_admin()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                Birthdate = dateTimePicker1.Text,
                Contact = txtContact.Text,
                Password = txtPassword.Text,
                CPassword = txtCPassword.Text,
                AdminID = txtAdminID.Text,
                AdminType = cboAdminType.Text
            };

            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password did not match! Please try again.");
                return;
            }
            admin.saveAdminInfo();

            MessageBox.Show("Admin Registered Successfully!");  
        }


        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            User_Interface1 user_Interface1 = new User_Interface1();
            user_Interface1.Show();
            this.Close();

        }
    }
}
