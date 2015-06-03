using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class HousekeepingReport
    {
        private string staffID;
        private string staff_FName;
        private string staff_LName;
        private string staff_Level;
        private string staff_DutyAssign;
        private string date;
        private int time;

        public HousekeepingReport(string staffID, string staff_FName, string staffLName, string staff_Level, string staff_DutyAssign, string date, int time)
        {
            this.staffID = staffID;
            this.staff_FName = staff_FName;
            this.staff_LName = staff_LName;
            this.staff_Level = staff_Level;
            this.staff_DutyAssign = staff_DutyAssign;
            this.date = date;
            this.time = time;
        }

        public HousekeepingReport()
        {
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Staff_FName
        {
            get { return staff_FName; }
            set { staff_FName = value; }
        }

        public string Staff_LName
        {
            get { return staff_LName; }
            set { staff_LName = value; }
        }

        public string Staff_Level
        {
            get { return staff_Level; }
            set { staff_Level = value; }
        }

        public string Staff_DutyAssign
        {
            get { return staff_DutyAssign; }
            set { staff_DutyAssign = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

    }
}
