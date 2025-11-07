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
    public partial class User_Terms : Form
    {
        public User_Terms()
        {
            InitializeComponent();
        }

        private void btn_agree_Click(object sender, EventArgs e)
        {
            
           DialogResult dialogResult = MessageBox.Show("Thank you for agreeing to the terms and conditions. You will now be redirected to the sign-up form.",
                "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                User_SignUp user_SignUp = new User_SignUp(); // 
                user_SignUp.Show();
                this.Hide();

            }
            else
            {
                // Do nothing, stay on the terms and conditions form
            }
        }

        private void btn_disagree_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("You must agree to the terms and conditions to proceed with the sign-up process. You be sent back to Log-in & SignUp",
                "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogresult == DialogResult.OK)
            {
                // puts the user back to login and sign up form again
                User_Interface1 user_Interface1 = new User_Interface1();
                user_Interface1.Show();
                this.Hide();

            }
            else
            {

                // Do nothing, stay on the terms and conditions form
            }
        }
    }
}
