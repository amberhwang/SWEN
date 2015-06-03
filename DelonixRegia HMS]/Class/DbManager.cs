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
        public static int insertCustomer(string CusID, string firstName, string lastName, string PhoneNum, string Email, string streetAdd, string postalCode, string countryofOrigin)
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
                comm.CommandText = "INSERT INTO [Customer](CusID, F_Name, L_Name, Phone_No, Email, Street_Add, Postal_Code, Country_Origin) VALUES (@CusId, @firstName, @lastName, @PhoneNum, @Email, @streetAddress, @postalCode, @countryofOrigin)";
                comm.Parameters.AddWithValue("@CusId", CusID);
                comm.Parameters.AddWithValue("@lastname", lastName);
                comm.Parameters.AddWithValue("@firstname", firstName);
                comm.Parameters.AddWithValue("@PhoneNum", PhoneNum);
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

        //update vacancy with the customerID with the RoomID
        public static int UpdateVacancytonull(string RoomID)
        {
            SqlConnection conn = null;
            int rowsinserted = 0;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE RoomInformation SET Vacancy=null WHERE RoomID='@RoomID'";
                comm.Parameters.AddWithValue("@roomid", RoomID);
                rowsinserted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;

            }
            return rowsinserted;
        }

        //Delete From booking 
        public static int DeleteBooking(string RoomID)
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
                comm.CommandText = "DELETE Booking WHERE RoomID='@RoomID'";
                comm.Parameters.AddWithValue("@roomid", RoomID);
                rowsinserted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;

            }
            return rowsinserted;
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

        public static Staff retrieveStaffDetails(string staffID)
        {
            Staff s1 = new Staff();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Staff WHERE StaffID=@StaffID";
                comm.Parameters.AddWithValue("@StaffID", staffID);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    s1.StaffID = "12312321321321";//(string)dr["StaffID"];
                    s1.Staff_FName = (string)dr["Staff_FName"];
                    s1.Staff_LName = (string)dr["Staff_LName"];
                    s1.Staff_PhoneNo = (int)dr["Staff_PhoneNo"];
                    s1.Staff_Email = (string)dr["Staff_Email"];
                    s1.Staff_PostalCode = (int)dr["Staff_PostalCode"];
                    s1.StaffHomeAdd = (string)dr["StaffHomeAdd"];
                    s1.Staff_CountryOrigin = (string)dr["Staff_CountryOrigin"];
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return s1;
        }

        //Get vacanacy By CustomerID(ber)
        public static Vanacy GetVanacyByCustomerID(string customerID)
        {
            Vanacy vanacy = new Vanacy();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM RoomOccpancyReport";
                comm.Parameters.AddWithValue("@CustomerID", customerID);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    vanacy.RoomOccID = (string)dr["RoomOccID"];
                    vanacy.Daily = (string)dr["Daily"];
                    vanacy.Weekly = (string)dr["Weekly"];
                    vanacy.Monthly = (string)dr["Monthly"];
                    vanacy.Yearly = (string)dr["Yearly"];
                    vanacy.Staff_Level = (string)dr["Staff_Level"];
                    vanacy.RoomID = (string)dr["RoomID"];
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return vanacy;

        }
        //insert totalcust report in db
        public static int InsertTotalCustReport(string TotalCusID, string TotalCusDate, string TotalCusTime, string RoomID)
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
                comm.CommandText = "INSERT INTO [TotalCustomersReport](TotalCusID, TotalCusDate, TotalCusTime, RoomID)"
                 + "VALUES (@TotalCusID, @TotalCusDate, @TotalCusTime, @RoomID)";
                comm.Parameters.AddWithValue("@TotalCusID", TotalCusID);
                comm.Parameters.AddWithValue("@TotalCusDate", TotalCusDate);
                comm.Parameters.AddWithValue("@TotalCusTime", TotalCusTime);
                comm.Parameters.AddWithValue("@RoomID", RoomID);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static bool Login(string username, string password)
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM [DRManagementDB].[dbo].[User] WHERE Username = '@customer';";
                comm.Parameters.AddWithValue("@customer", username);
                SqlDataReader dr = comm.ExecuteReader();
                if(dr.Read())
                {
                    string pass = (string)dr["Password"];
                    if(password == pass)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(SqlException e)
            {
                throw e;
            }
            return true;
        }

        public static int DeleteEBooking(string bookingID)
        {
            SqlConnection conn = null;
            int rowsUpdated = 0;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM Booking WHERE BookingID='@bookingID'";
                comm.Parameters.AddWithValue("@bookingID", bookingID);
                rowsUpdated = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return rowsUpdated;
        }
    }

}

