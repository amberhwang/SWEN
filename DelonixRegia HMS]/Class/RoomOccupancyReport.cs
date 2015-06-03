using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class RoomOccupancyReport
    {
        private string roomOccID;
        private string daily;
        private string weekly;
        private string monthly;
        private string yearly;
        private string staff_Level;
        private string roomID;

        public RoomOccupancyReport(string RoomOccID, string Daily, string Weekly, string Monthly, string Yearly, string Staff_Level, string RoomID)
        {
            this.RoomOccID = roomOccID;
            this.Daily = daily;
            this.Weekly = weekly;
            this.Monthly = monthly;
            this.Yearly = roomID;
            this.Staff_Level = staff_Level;
            this.RoomID = roomID;
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
            get { return roomID; }
            set { roomID = value; }
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
