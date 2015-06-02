using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class DbManager
    {
        //#1 Method insertCustomer
        public static int insertCustomer(string RoomNumber, string firstName, string lastName, string PhoneNum, string Email, string streetAdd, string postalCode, string countryofOrigin)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO [Customer](F_Name, L_Name, Phone_No, Email, Street_Add, Postal_Code, Country_Origin) ( VALUES (@firstName, @lastName, @PhoneNum, @Email, @streetAddress, @postalCode, @countryofOrigin)";
                comm.Parameters.AddWithValue("@lastname", lastName);              
                comm.Parameters.AddWithValue("@firstname", firstName);
                comm.Parameters.AddWithValue("@phonenumber", PhoneNum);
                comm.Parameters.AddWithValue("@email", Email);
                comm.Parameters.AddWithValue("@streetAddress", streetAdd);
                comm.Parameters.AddWithValue("@postalcode", postalCode);
                comm.Parameters.AddWithValue("@countryoforigin", countryofOrigin);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        //#2 Method insertBooking

        public static int insertBooking(string bookingID, string checkIn_Time, string checkOut_Time, string checkIn_Date, string checkOut_Date, string description, string roomID, string cusID)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO [Booking](BookingID, CheckIn_Time, CheckOut_Time, CheckIn_Date, CheckOut_Date, Description, RoomID, CusID) ( VALUES (@firstName, @lastName, @PhoneNum, @Email, @streetAddress, @postalCode, @countryofOrigin)";
                comm.Parameters.AddWithValue("@bookingid", bookingID);
                comm.Parameters.AddWithValue("@checkin_time", checkIn_Time);
                comm.Parameters.AddWithValue("@checkout_time", checkOut_Time);
                comm.Parameters.AddWithValue("@checkin_date", checkIn_Date);
                comm.Parameters.AddWithValue("@checkout_date", checkOut_Date);
                comm.Parameters.AddWithValue("@description", description);
                comm.Parameters.AddWithValue("@roomid", roomID);
                comm.Parameters.AddWithValue("@cusid", cusID);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        //#3 Method updateRoomInformationTable

        public static int UpdateRoomInfousingRoomID(string RoomID, string CusID)
        {
            SqlConnection conn = null;
            int rowsinserted = 1;
            try
            {    //update vancancy with the customerID with the RoomID
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE RoomInformation SET Vacancy= @CusID WHERE CusID='@cusID'";
                comm.Parameters.AddWithValue("@roomid", RoomID);
                comm.Parameters.AddWithValue("@CusID", CusID);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;

            }
            return rowsinserted;
        }

        //retrieve 
    }

}

