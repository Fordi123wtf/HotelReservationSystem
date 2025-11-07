using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ViewGrid
{
    public class cls_admin
    {
        public string AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthdate { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public string CPassword { get; set; }   
        public string AdminType { get; set; }

        public void saveAdminInfo()
        {
            
            // Baka mag loko yung Database mo
            // ADDED IN THIS sqlcon: PORT = 3307 AND pwd='' <-- only works for me btw, so remove it, -Lamando

            //                                                                        admin_info to hotel_reservation.
            MySqlConnection sqlcon = new MySqlConnection("server=localhost; port=3307;database=hotel_reservation;uid=root;pwd=''");
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlcon.Open();

            // made it parametarize for security reasons, avoid sql injections
            sqlcmd.CommandText = $"INSERT INTO admin_info (Last_Name, First_Name, Email, Address, Birthdate, Contact_No, Password, CPassword, Admin_ID, Admin_Type)" +
                                 $"values (@Last_Name, @First_Name, @Email, @Address, @Birthdate, @Contact_No, @Password, @CPassword, @Admin_ID, @Admin_Type)";



            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;


            sqlcmd.Parameters.AddWithValue("@Last_Name", LastName);
            sqlcmd.Parameters.AddWithValue("@First_Name", FirstName);
            sqlcmd.Parameters.AddWithValue("@Email", Email);
            sqlcmd.Parameters.AddWithValue("@Address", Address);
            sqlcmd.Parameters.AddWithValue("@Birthdate", Birthdate);
            sqlcmd.Parameters.AddWithValue("@Contact_No", Contact);
            sqlcmd.Parameters.AddWithValue("@Password", Password);
            sqlcmd.Parameters.AddWithValue("@CPassword", CPassword);
            sqlcmd.Parameters.AddWithValue("@Admin_ID", AdminID);
            sqlcmd.Parameters.AddWithValue("@Admin_Type", AdminType);

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Saved Data successfully!");

            sqlcon.Close();



        }


    }

    public class cls_user
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthdate { get; set; }
        public string Contact_No { get; set; }
        public string Password { get; set; }
        public string CPassword { get; set; }


        public void saveUserInfo()
        {
            MySqlConnection sqlcon = new MySqlConnection("server=localhost; port=3307;database=hotel_reservation;uid=root;pwd=''");
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlcon.Open();
            sqlcmd.CommandText = $"INSERT INTO user_info (Last_Name, First_Name, Email, Address, Birthdate, Contact_No, Password, CPassword)" +
                                 $"values (@Last_Name, @First_Name, @Email, @Address, @Birthdate, @Contact_No, @Password, @CPassword)";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;
            sqlcmd.Parameters.AddWithValue("@Last_Name", LastName);
            sqlcmd.Parameters.AddWithValue("@First_Name", FirstName);
            sqlcmd.Parameters.AddWithValue("@Email", Email);
            sqlcmd.Parameters.AddWithValue("@Address", Address);
            sqlcmd.Parameters.AddWithValue("@Birthdate", Birthdate);
            sqlcmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            sqlcmd.Parameters.AddWithValue("@Password", Password);
            sqlcmd.Parameters.AddWithValue("@CPassword", CPassword);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Saved Data successfully!");
            sqlcon.Close();
        }
    }
}

