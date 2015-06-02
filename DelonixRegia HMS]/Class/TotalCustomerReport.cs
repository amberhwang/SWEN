using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class TotalCustomerReport
    {
        private string totalcusid;
        private string totalcusdate;
        private string totalcustime;
        private string roomid;

        public TotalCustomerReport()
        {
        }
        public TotalCustomerReport(string totalcusid, string totalcusdate, string totalcustime, string roomid)
        {
            this.totalcusid = totalcusid;
            this.totalcusdate = totalcusdate;
            this.totalcustime = totalcustime;
            this.roomid = roomid;
        }
        public string TotalCusID
        {
            get { return totalcusid; }
            set { totalcusid = value; }
        }
        public string TotalCusDate
        {
            get { return totalcusdate; }
            set { totalcusdate = value; }
        }
        public string TotalCusTime
        {
            get { return totalcustime; }
            set { totalcustime = value; }
        }
        public string RoomID
        {
            get { return roomid; }
            set { roomid = value; }
        }
    }
}
