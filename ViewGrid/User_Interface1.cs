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
    public partial class User_Interface1 : Form
    {
        public User_Interface1()
        {
            InitializeComponent();
        }


        private void btn_LogIn_1_Click(object sender, EventArgs e)
        {
            // both admin and user log in here
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();

        }

        private void btn_SignUp_1_Click(object sender, EventArgs e)
        {
            // only user sign up here

            User_Terms user_Terms = new User_Terms();
            user_Terms.Show();
            this.Hide();


        }

        private void User_Interface1_Load(object sender, EventArgs e)
        {

        }
    }
}
