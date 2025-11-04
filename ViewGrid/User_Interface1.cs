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
            AdminLogIn adminLogIn = new AdminLogIn();   
            adminLogIn.Show();
            this.Hide();
        }

        private void btn_SignUp_1_Click(object sender, EventArgs e)
        {
            AdminSignUp adminSignUp = new AdminSignUp();
            adminSignUp.Show();
            this.Hide();

        }

        private void User_Interface1_Load(object sender, EventArgs e)
        {

        }
    }
}
