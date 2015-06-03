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

        public RoomOccupancyReport(string RoomOccID, string Daily, string Weekly, string Monthly, string Yearly)
        {
            this.RoomOccID = roomOccID;
            this.Daily = daily;
            this.Weekly = weekly;
            this.Monthly = monthly;
            this.Yearly = yearly;
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
            get { return yearly; }
            set { yearly = value; }
        }
    }
}
