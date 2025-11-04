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
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            // ADDED IN THIS sqlcon: PORT = 3307 AND pwd='' <-- only works for me btw, Lamando
            MySqlConnection sqlcon = new MySqlConnection("server=localhost;database=hotel_reservation; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();   

            sqlcon.Open();

            // BTW, Employee and Manager can access this, di ako sure kung tama ba ito??
            sqlcmd.CommandText = $"SELECT * FROM admin_info WHERE Email = '{email}' AND Password = '{password}'";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;

            MySqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Admin Log In Successful!");
                Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
                admin_DashBoard.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid Email or Password!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            


        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            User_Interface1 user_Interface1 = new User_Interface1();
            user_Interface1.Show();
            this.Hide();

        }
    }
}
