﻿using System;
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
                comm.CommandText = "INSERT INTO [Booking](BookingID, CheckIn_Time, CheckOut_Time, CheckIn_Date, CheckOut_Date, Description, RoomID, CusID)"
                 + "VALUES (@bookingid, @checkin_time, @checkout_time, @checkin_date, @checkout_date, @description, @roomid, @cusid)";
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
            int rowsinserted = 0;
            try
            {    //update vancancy with the customerID with the RoomID
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE RoomInformation SET Vacancy='@CusID' WHERE RoomID='@RoomID'";
                comm.Parameters.AddWithValue("@roomid", RoomID);
                comm.Parameters.AddWithValue("@CusID", CusID);
                rowsinserted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;

            }
            return rowsinserted;
        }

        //retrieve CustomerID by reading in CustomerName
        public static Customer retrieveCustomerIDusingCustomerName(string F_Name, string L_Name)
        {
            Customer c = new Customer();
            SqlConnection conn = null;

            try
            {    //Select Customer ID using the Customer Name
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT CusID FROM Customer WHERE F_Name = @F_Name and WHERE L_Name = @L_Name";
                comm.Parameters.AddWithValue("@F_Name", F_Name);
                comm.Parameters.AddWithValue("@L_Name", L_Name);
                SqlDataReader dr = comm.ExecuteReader();
                conn.Close();
                if (dr.Read())
                {
                    c.F_Name = (string)dr["F_Name"];
                    c.L_Name = (string)dr["L_Name"];
                }
            }
            catch (Exception e)
            {
                throw e;

            }
            return c;
        } 

        //Get Room By RoomID(ber)
        public static Room GetRoomByRoomID(string roomID)
        {

            Room room = new Room();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Room WHERE RoomID=@RoomID";
                comm.Parameters.AddWithValue("@RoomID", roomID);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    //private string roomID;
                    //private string room_Type;
                    //private string bed_Type;
                    //private string room_Rates;
                    //private string vacancy;
                    //private string add_Remarks;
                    //private int room_Level;
                    //private int roomCapacity_People;

                    room.RoomID = (string)dr["RoomID"];
                    room.Room_Type = (string)dr["Room_Type"];
                    room.Bed_Type = (string)dr["Bed_Type"];
                    room.Room_Rates = (string)dr["Room_Rates"];
                    room.Vacancy = (string)dr["Vacancy"];
                    room.Add_Remarks = (string)dr["Add_Remarks"];
                    room.Room_Level = (int)dr["Room_Level"];
                    room.RoomCapacity_People = (int)dr["RoomCapacity_People"];
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return room; //??
        }
    }

}

