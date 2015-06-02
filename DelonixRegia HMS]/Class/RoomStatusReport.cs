using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class RoomStatusReport
    {
        private string statusID;
        private string allRoomVacancy;
        private string allRoomStatus;
        private string statusDate;
        private string statusTime;

        public RoomStatusReport(string statusID, string allRoomVacancy, string allRoomStatus, string statusDate, string statusTime)
        {
            this.statusID = statusID;
            this.allRoomVacancy = allRoomVacancy;
            this.allRoomStatus = allRoomStatus;
            this.statusDate = statusDate;
            this.statusTime = statusTime;
        }

        public string StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }

        public string AllRoomVanancy
        {
            get { return allRoomVacancy; }
            set { allRoomVacancy = value; }
        }

        public string AllRoomStatus
        {
            get { return AllRoomStatus; }
            set { AllRoomStatus = value; }
        }

        public string StatusDate
        {
            get { return statusDate; }
            set { statusDate = value; }
        }

        public string StatusTime
        {
            get { return statusTime; }
            set { statusTime = value; }
        }
    }
}
