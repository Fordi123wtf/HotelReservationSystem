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
    public partial class RoomTypeManagement : Form
    {
        public RoomTypeManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string roomtype = txtRoomType.Text;
            string name = txtName.Text;
            string price = txtPrice.Text;
            string beds = txtBeds.Text;
            string bedtype = txtBedType.Text;
            string occupancy = txtOccupancy.Text;

            MySqlConnection sqlcon = new MySqlConnection("server=localhost; database=admin_roomtypemanagement; uid=root");
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlcon.Open();

            sqlcmd.CommandText = $"INSERT INTO roomtypemanagement (Room_Type, Name, Price, Beds, Bed_Types, Max_Occupancy)" +
                                 $"values ('{roomtype}', '{name}', '{price}', '{beds}', '{bedtype}', '{occupancy}')";

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;

            sqlcmd.ExecuteNonQuery();

            sqlcon.Close();

            MessageBox.Show("Room Added Successfully!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            RoomTypeManagement RoomTypeManagement2 = new RoomTypeManagement();
            RoomManage RoomManage2 = new RoomManage();

            this.Hide();
            RoomManage2.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
