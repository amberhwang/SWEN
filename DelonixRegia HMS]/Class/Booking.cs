using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class Booking
    {

        private string bookingID;
        private string checkIn_Time;
        private string checkOut_Time;
        private string checkIn_Date;
        private string checkOut_Date;
        private string description;
        private string roomID;
        private string cusID;

        public Booking(string bookingID, string checkIn_Time, string checkOut_Time, string checkIn_Date, string checkOut_Date, string description, string roomID, string cusID)
        {
            this.bookingID = bookingID;
            this.checkIn_Time = checkIn_Time;
            this.checkOut_Time = checkOut_Time;
            this.checkIn_Date = checkIn_Date;
            this.checkOut_Date = checkOut_Date;
            this.description = description;
            this.roomID = roomID;
            this.cusID = cusID;
        }

        public string CusID
        {
            get { return cusID; }
            set { cusID = value; }
        }

        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public string CheckIn_Time
        {
            get { return checkIn_Time; }
            set { checkIn_Time = value; }
        }

        public string CheckOut_Time
        {
            get { return checkOut_Time; }
            set { checkOut_Time = value; }
        }

        public string CheckIn_Date
        {
            get { return checkIn_Date; }
            set { checkIn_Date = value; }
        }

        public string CheckOut_Date
        {
            get { return checkOut_Date; }
            set { checkOut_Date = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
    }
}
