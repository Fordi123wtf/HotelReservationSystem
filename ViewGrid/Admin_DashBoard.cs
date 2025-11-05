using MySqlX.XDevAPI.Common;
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
    public partial class Admin_DashBoard : Form
    {
        public Admin_DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logging out?", "Do you want to Exit?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Logout canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            User_Interface1 user_Interface1 = new User_Interface1();
            user_Interface1.Show();
            this.Close();
        }

        private void btn_Maintenance_Scheduling_Click(object sender, EventArgs e)
        {
            Maintenance_Sched maintenance_Sched = new Maintenance_Sched();
            maintenance_Sched.Show();
            this.Hide();
        }

        private void btn_Room_Type_Management_Click(object sender, EventArgs e)
        {
            RoomTypeManagement roomTypeManagement = new RoomTypeManagement();
            roomTypeManagement.Show();
            this.Hide();

        }

        private void btn_Room_Management_Click(object sender, EventArgs e)
        {
            RoomManage roomManage = new RoomManage();
            roomManage.Show();
            this.Hide();

        }

        private void btn_User_Records_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Employee_Management_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement= new EmployeeManagement();
            employeeManagement.Show();
            this.Hide();
        }

        private void btn_Reservation_Click(object sender, EventArgs e) // Nandito yung mga Maintenance FEE
        {
            ReservationDetails reservationDetails = new ReservationDetails();
            reservationDetails.Show();
            this.Hide();

        }

        private void Admin_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
