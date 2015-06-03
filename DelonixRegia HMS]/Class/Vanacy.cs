using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class Vanacy
    {
        private string roomOccID;
        private string daily;
        private string weekly;
        private string monthly;
        private string yearly;
        private string staff_Level;
        private string roomID;

        //ber
        public Vanacy(string roomOccID, string daily, string weekly, string monthly, string yearly, string staff_Level, string roomID)
        {
            this.RoomOccID = RoomOccID;
            this.Daily = daily;
            this.Weekly = weekly;
            this.Monthly = monthly;
            this.Yearly = yearly;
            this.Staff_Level = staff_Level;
            this.RoomID = roomID;
        }

        public Vanacy()
        {
        }

        public string RoomOccID
        {
            get { return roomOccID; }
            set { roomOccID = value; }
        }

        public string Daily
        {
            get { return daily; }
            set { daily = value; }

        }

        public string Weekly
        {
            get { return weekly; }
            set { weekly = value; }

        }

        public string Monthly
        {
            get { return monthly; }
            set { monthly = value; }

        }

        public string Yearly
        {
            get { return Yearly; }
            set { Yearly = value; }

        }

        public string Staff_Level
        {
            get { return Staff_Level; }
            set { Staff_Level = value; }

        }

        public string RoomID
        {
            get { return RoomID; }
            set { RoomID = value; }

        }
    }
}
