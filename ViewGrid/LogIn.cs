using MySql.Data.MySqlClient;
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
    // Just delete this comment. Nov 7 2025, time: 12:59PM

    // CHANGING AdminLogIn into LogIn only since admin and users will log in here?
    // Name lang naman papalitan ko dito 
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            using (MySqlConnection sqlcon = new MySqlConnection("server=localhost;port=3307;database=hotel_reservation;uid=root;pwd=''"))
            {
                sqlcon.Open();

                //used "using" statements to ensure proper disposal of resources, automatic kasi kapag gumamit ka ng "using" auto close yung sqlcon

                // ADMIN LOGIN CHECK
                using (MySqlCommand sqlcmd = new MySqlCommand($"SELECT * FROM admin_info WHERE Email = @Email AND Password = @Password", sqlcon))
                {
                    sqlcmd.Parameters.AddWithValue("@Email", email);
                    sqlcmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = sqlcmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Admin Log In Successful!");
                            Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
                            admin_DashBoard.Show();
                            this.Hide();
                            return; // stop after successful admin login
                        }
                    }
                }

                // USER LOGIN CHECK
                using (MySqlCommand sqlcmd = new MySqlCommand($"SELECT * FROM user_info WHERE Email = @Email AND Password = @Password", sqlcon))
                {
                    sqlcmd.Parameters.AddWithValue("@Email", email);
                    sqlcmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader userReader = sqlcmd.ExecuteReader())
                    {
                        if (userReader.HasRows)
                        {
                            MessageBox.Show("User Log In Successful!");
                            User_MainMenu user_MainMenu = new User_MainMenu();
                            user_MainMenu.Show();
                            this.Hide();
                            return;
                        }
                    }
                }

                // IF BOTH FAIL
                MessageBox.Show("Invalid Email or Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btn_return_Click(object sender, EventArgs e)
        {
            User_Interface1 user_Interface1 = new User_Interface1();
            user_Interface1.Show();
            this.Hide();
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
