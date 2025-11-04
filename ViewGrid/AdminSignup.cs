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
    public partial class AdminSignup : Form
    {
        public AdminSignup()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string birthdate = dateTimePicker1.Text;
            string contact = txtContact.Text;
            string passoword = txtPassword.Text;
            string cpassword = txtCPassword.Text;
            string adminid = txtAdminID.Text;
            string admintype = cboAdminType.Text;
            MySqlConnection sqlcon = new MySqlConnection("server=localhost; database=admin_login; uid=root");
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlcon.Open();

            sqlcmd.CommandText = $"INSERT INTO admin_info (Last_Name, First_Name, Email, Address, Birthdate, Contact_No, Password, CPassword, Admin_ID, Admin_Type)" +
                                 $"values ('{firstname}', '{lastname}', '{email}', '{address}', '{birthdate}', '{contact}', '{passoword}', '{cpassword}', '{adminid}', '{admintype}')";

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;

            sqlcmd.ExecuteNonQuery();

            sqlcon.Close();
        }
    }
}
