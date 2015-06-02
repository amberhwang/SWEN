using DelonixRegia_HMS_.Class;
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

namespace DelonixRegia_HMS_
{
    public partial class Form1 : Form
    {
        public string key = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (key == "")
            {
                e.Cancel = true;
            }

            else
            {
                e.Cancel = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            key = "Hello";
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            //Check the availability of the hotel rooms
            SqlConnection conn = null;
            DataTable t = new DataTable();
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=YONGXIANG\\SQLEXPRESS;Initial Catalog=DRManagementDB;Integrated Security=True";
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT [RoomID], [Room_Type], [Bed_Type], [Room_Rates], [RoomCapacity_People] FROM [RoomInformation] WHERE Vacancy != null ", conn))
                {

                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            if (t == null)
            {
                lblAvailability.Text = "No More Rooms";
                lblAvailability.ForeColor = System.Drawing.Color.Crimson;
            }
            else
            {
                lblAvailability.Text = "FREE";
                lblAvailability.ForeColor = System.Drawing.Color.ForestGreen;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Store the variables RoomInformation
            string RoomNum = tbxRoomNumber.Text;
            string FirstN = tbxFN.Text;
            string LastN = tbxLN.Text;
            string PhoneNum = tbxPN.Text;
            string Email = tbxEmail.Text;
            string PostalCode = tbxPostal.Text;
            string CountryofOrigin = tbxCountry.Text;
            string streetAddr = tbxStreet.Text;
            string CusID = "cus" + DateTime.Now.ToString("ddMMyyyyHHMMSS");
            string Description = "";

            //store the variables Booking
            string bookingID = "";
            string checkOut_Time = "";
            string checkIn_Time = "";
            string checkIn_Date = "";
            string checkOut_Date = "";
            string RoomID = "";


            //store the variables for Customer

            string f_Name = "";
            string l_Name = "";
            string phone_No = "";
            string email = "";
            string street_Add = "";
            string postal_Code = "";
            string country_Origin = "";

            string vacancy = CusID;

            //Call #3 method from the DBManager

            DbManager.insertCustomer(RoomNum, FirstN, tbxLN.Text, tbxPN.Text, tbxEmail.Text, tbxPostal.Text, tbxCountry.Text, tbxStreet.Text);

            DbManager.insertBooking(bookingID, checkOut_Time, checkIn_Time, checkIn_Date, checkOut_Date, RoomID, CusID, Description);

            DbManager.retrieveCustomerIDusingCustomerName(tbxFN.Text, tbxLN.Text);
            //#1 Method insertCustomer
            int rowsInserted = DbManager.insertCustomer(CusID, f_Name, l_Name, phone_No, email, street_Add, postal_Code, country_Origin);
            //#2 Method insertBooking
            rowsInserted = DbManager.insertBooking(bookingID, checkIn_Time, checkOut_Time, checkIn_Date, checkOut_Date, RoomID, CusID, Description);
            //#3 Method updateRoomInformationTable
            rowsInserted = DbManager.UpdateRoomInfousingRoomID(RoomID, CusID);
            //if-else statement to show whether it is successful or not
            if (rowsInserted == 1)
            {
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Added Unsuccessfully");
            }

            //clear all textbox
            tbxFN.Text = "";
            lblAvailability.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete the booking based RoomID and set the vancacy = null


            MessageBox.Show("Successfully Checked Out");
        }

        private void btnRetrieveH_Click(object sender, EventArgs e)
        {
            string staffID = textBox4.Text;
            //Retrieve Staff Information
            //Check the availability of the hotel rooms
            SqlConnection conn = null;
            DataTable t = new DataTable();
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=YONGXIANG\\SQLEXPRESS;Initial Catalog=DRManagementDB;Integrated Security=True";
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM [Staff] WHERE [StaffID] = " + staffID + ";", conn))
                {
                    a.Fill(t);
                    dataGridView3.DataSource = t;

                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }


            btnViewStaff.Visible = true;
        }

        private void btnRefreshDGV_Click(object sender, EventArgs e)
        {
            //Check the availability of the hotel rooms
            SqlConnection conn = null;
            DataTable t = new DataTable();
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=YONGXIANG\\SQLEXPRESS;Initial Catalog=DRManagementDB;Integrated Security=True";
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM [Staff]", conn))
                {
                    a.Fill(t);
                    dataGridView3.DataSource = t;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGDisplay_Click(object sender, EventArgs e)
        {
           
        }

    }
}
