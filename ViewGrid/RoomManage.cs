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
using System.Xml.Linq;

namespace ViewGrid
{
    public partial class RoomManage : Form
    {
        public RoomManage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            MySqlConnection sqlcon = new MySqlConnection("server=localhost; database=admin_roomtypemanagement; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            sqlcon.Open();

            if (search == null)
                sqlcmd.CommandText = $"SELECT * FROM roomtypemanagement WHERE Price";

            else
                sqlcmd.CommandText = $"SELECT * FROM roomtypemanagement WHERE Name LIKE '%{search}%'";

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;

            sqlDA.SelectCommand = sqlcmd;
            sqlDA.Fill(DS, "tablefetch");

            dataGridView1.DataSource = DS;
            dataGridView1.DataMember = "tablefetch";

            sqlcon.Close();
        }

        public void updaterecord (string roomtype,string name,string price,string beds,string bedtype,string occupancy)
        {
            MySqlConnection sqlcon = new MySqlConnection("server=localhost; database=admin_roomtypemanagement; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlcon.Open();

            sqlcmd.CommandText = $"UPDATE roomtypemanagement" +
                $"SET Room_Type = '{roomtype}' , Name = '{name}', Price = '{price}', Beds = '{beds}', Bed_Types = '{bedtype}',  Max_Occupancy = '{occupancy}'" +
                $"WHERE Room_Type = '{roomtype}'";

            sqlcmd.CommandType = CommandType.Text ; 
            sqlcmd.Connection = sqlcon;

            sqlcmd.ExecuteNonQuery();

            sqlcon.Close() ;
        }

        public void deleterecord(string roomtype)
        {
            MySqlConnection sqlcon = new MySqlConnection("server=localhost; database=admin_roomtypemanagement; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlcon.Open();

            sqlcmd.CommandText = $"DELETE roomtypemanagement WHERE roomtypemanagement " +
                $"SET Room_Type = '{roomtype}' , Name = '{name}', Price = '{price}', Beds = '{beds}', Bed_Types = '{bedtype}',  Max_Occupancy = '{occupancy}'" +
                $"WHERE Room_Type = '{roomtype}'";

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;

            sqlcmd.ExecuteNonQuery();

            sqlcon.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomTypeManagement RoomTypeManagement2 = new RoomTypeManagement();
            RoomManage RoomManage2 = new RoomManage();

            this.Hide();
            RoomTypeManagement2.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void RoomManage_Load(object sender, EventArgs e)
        {

        }
    }
}
