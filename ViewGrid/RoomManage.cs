﻿using MySql.Data.MySqlClient;
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

namespace Hotel
{
    public partial class RoomManage : Form
    {
        public RoomManage()
        {
            InitializeComponent();
        }

        private void RoomManage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomTypeManagement RoomTypeManagement2 = new RoomTypeManagement();
            RoomManage RoomManage2 = new RoomManage();

            this.Hide();
            RoomTypeManagement2.Show();
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

        private void btnEdit_Click(string roomtype, string name,string price,string bed,string bedtype,string occupancy)

        {
            MySqlConnection sqlcon = new MySqlConnection("server=localhost; database=admin_roomtypemanagement; uid=root;");
            MySqlCommand sqlcmd = new MySqlCommand();

            sqlcon.Open();

            sqlcmd.CommandText = $"UPDATE roomtypemanagement" +
                                $"SET Room_Type = '{roomtype}', Name = '{name}', Price = '{price}', beds = '{bed}', Bed_Types = '{bedtype}', Max_Occupancy = '{occupancy}'";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlcon;

            sqlcmd.ExecuteNonQuery();

            sqlcon.Close();

            MessageBox.Show("Room Updated!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
