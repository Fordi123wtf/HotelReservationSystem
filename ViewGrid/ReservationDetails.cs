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
    public partial class ReservationDetails : Form
    {
        private int standardRoomCount = 0;
        private int doubleRoomCount = 0;
        private int premiumRoomCount = 0;
        public ReservationDetails()
        {
            InitializeComponent();
        }


       private void calculateTotals()
        {
            DateTime checkIn = dtp_checkInDate.Value.Date;
            DateTime checkOut = dtp_checkOutDate.Value.Date;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date. If this prompt when you click reservation button, it's just the datagridview has no records.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_checkOutDate.Value = dtp_checkInDate.Value.AddDays(1); // if check out is the same as checkIn or less than checkIn, this will prompt and add one day.
                checkOut = dtp_checkOutDate.Value.Date; // to get the updated value of checkOUT
                
            }

            int totalNights = (checkOut - checkIn).Days;
            lbl_totalNights.Text = totalNights.ToString();

            int adultCount = (int)numUd_adult.Value;
            int childCount = (int)numUd_child.Value;
            lbl_totalGuestCount.Text = (adultCount + childCount).ToString();

            decimal totalRoomPrice = 0; // ← You can change this later depending on selected room

            foreach (DataGridViewRow row in dataGridView1.Rows) // iterate through each row in the DataGridView
            {
                // since there is no cells in the datagridview new row placeholder, we need to skip it, so it doesn't break

                if (row.IsNewRow) continue; // skip the new row placeholder
                if (row.Cells["Price"].Value == null) continue; // skip if price cell is null

                if (row.Cells["Price"].Value != null) // if price is empty this will not work
                {
                    string priceText = row.Cells["Price"].Value.ToString().Replace("₱", "").Replace(",", "");
                    if (decimal.TryParse(priceText, out decimal roomPrice))
                    {
                        totalRoomPrice += roomPrice;
                    }
                }
                
            }

            


            decimal totalRoomCost = totalNights * totalRoomPrice;
            decimal totalGuestCost = (adultCount * 300 + childCount * 150) * totalNights; // if charged per night
            decimal totalCost = totalRoomCost + totalGuestCost;

            lbl_totalPrice.Text = "₱" + totalCost.ToString("#,##0.00");
        }

        private string GetNextRoomNumber(string roomType)
        {
            if (roomType == "Standard")
            {
                standardRoomCount++;
                return "S" + standardRoomCount.ToString("00"); // S01, S02, etc.
            }
            else if (roomType == "Double")
            {
                doubleRoomCount++;
                return "D" + doubleRoomCount.ToString("00");
            }
            else if (roomType == "Premium")
            {
                premiumRoomCount++;
                return "P" + premiumRoomCount.ToString("00"); // P01, P02, etc.
            }
            
                return "";
        }





        private void ReservationDetails_Load(object sender, EventArgs e)
        {
            



           dataGridView1.Columns.Add("RoomNumber", "Room Number");
           dataGridView1.Columns.Add("RoomType", "Room Type");
           dataGridView1.Columns.Add("Price", "Price");


        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
            admin_DashBoard.Show();
            this.Hide();

        }


        private void numUd_adult_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();

        }

        private void numUd_child_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void dtp_checkInDate_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void dtp_checkOutDate_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btn_add_standard_Click(object sender, EventArgs e)
        {
            string roomType = "Standard";
            string roomNumber = GetNextRoomNumber(roomType);
            decimal price = 3000m; // this is 3k

            dataGridView1.Rows.Add(roomNumber, roomType, price.ToString("₱#,##0.00"));

        }

        private void btn_add_double_Click(object sender, EventArgs e)
        {
            string roomType = "Double";
            string roomNumber = GetNextRoomNumber(roomType);
            decimal price = 7000m; // this is 7k

            dataGridView1.Rows.Add(roomNumber, roomType, price.ToString("₱#,##0.00"));
        }

        private void btn_add_premium_Click(object sender, EventArgs e)
        {
            string roomType = "Premium";
            string roomNumber = GetNextRoomNumber(roomType);
            decimal price = 15000m; // this is 15k


            dataGridView1.Rows.Add(roomNumber, roomType, price.ToString("₱#,##0.00"));

        }

        private void btn_checkTotalCost_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check-In Date: " + dtp_checkInDate.Value.ToShortDateString() +
                "\nCheck-Out Date: " + dtp_checkOutDate.Value.ToShortDateString() +
                "\nTotal Nights: " + lbl_totalNights.Text +
                "\nTotal Guests: " + lbl_totalGuestCount.Text +
                "\nTotal Price: " + lbl_totalPrice.Text,
                "Reservation Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            calculateTotals();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateTotals();
        }

        private void btn_standard_remove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["RoomType"].Value != null && r.Cells["RoomType"].Value.ToString() == "Standard")
                .ToList()
                .ForEach(r => dataGridView1.Rows.Remove(r));

        }

        private void btn_double_remove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["RoomType"].Value != null && r.Cells["RoomType"].Value.ToString() == "Double")
                .ToList()
                .ForEach(r => dataGridView1.Rows.Remove(r));

        }

        private void btn_premium_remove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows
                .Cast<DataGridViewRow>() // iterates through datagridview rows
                .Where(r => r.Cells["RoomType"].Value != null && r.Cells["RoomType"].Value.ToString() == "Premium")
                .ToList()
                .ForEach(r => dataGridView1.Rows.Remove(r));
        }

        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            // Can only do this if I already have the client database... iyak na ako baws

            DialogResult result = MessageBox.Show("Are you sure you want to Check-Out this Guest?", "Confirm Check-Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);  

            if (result == DialogResult.Yes)
            {
                calculateTotals();
                // maya gawin ko ito, push muna. TimeCheck: 11:40AM, Nov 4, 2025

            }
        }
    }
}
