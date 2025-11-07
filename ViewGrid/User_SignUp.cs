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
    public partial class User_SignUp : Form
    {
        public cls_user currentUser;
        public User_SignUp()
        {
            InitializeComponent();
            //this.currentUser = currentUser;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void User_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            User_Interface1 user_Interface1 = new User_Interface1();
            user_Interface1.Show();
            this.Hide();

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            cls_user user = new cls_user()
            {
                FirstName = txt_FName.Text,
                LastName = txt_LName.Text,
                Email = txt_email.Text,
                Address = txt_address.Text,
                Birthdate = dtp_birthdate.Text,
                Contact_No = txt_contactNo.Text,
                Password = txt_password.Text,
                CPassword = txt_Cpassword.Text
                // AdminID and AdminType are not needed for user sign up
            };
            if (txt_password.Text != txt_Cpassword.Text)
            {
                MessageBox.Show("Password did not match! Please try again.");
                return;
            }
            if (string.IsNullOrWhiteSpace(user.FirstName) ||
                string.IsNullOrWhiteSpace(user.LastName) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Address) ||
                string.IsNullOrWhiteSpace(user.Birthdate) ||
                string.IsNullOrWhiteSpace(user.Contact_No) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(user.CPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            // security question txtbox should be here later, kaso di ko alam ano gagawin diyan

            try
            {
                user.saveUserInfo();
                MessageBox.Show("User saved successfully.");

                User_SignupComplete user_SignupComplete = new User_SignupComplete();
                user_SignupComplete.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save user: " + ex.Message);
            }

        }
    }
}
