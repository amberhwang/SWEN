using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class Staff
    {
        private string staffID;
        private string staff_FName;
        private string staff_LName;
        private string staff_DOB;
        private string staff_BankAccNo;
        private int staff_PhoneNo;
        private string staff_Email;
        private string staffHomeAdd;
        private int staff_PostalCode;
        private string staff_CountryOrigin;
        private string staff_Level;

        public Staff(string staffID, string staff_FName, string staff_LName, string staff_DOB, string staff_BankAccNo, int staff_PhoneNo, string staff_Email, string staffHomeAdd, int staff_PostalCode, string staff_CountryOrigin, string staff_Level)
        {
            this.staffID = staffID;
            this.staff_FName = staff_FName;
            this.staff_LName = staff_LName;
            this.staff_DOB = staff_DOB;
            this.staff_BankAccNo = staff_BankAccNo;
            this.staff_PhoneNo = staff_PhoneNo;
            this.staff_Email = staff_Email;
            this.staffHomeAdd = staffHomeAdd;
            this.staff_PostalCode = staff_PostalCode;
            this.staff_CountryOrigin = staff_CountryOrigin;
            this.staff_Level = staff_Level;
        }

        public Staff()
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
        public string Staff_DOB
        {
            get { return staff_DOB; }
            set { staff_DOB = value; }
        }

        public string Staff_BankAccNo
        {
            get { return staff_BankAccNo; }
            set { staff_BankAccNo = value; }
        }
        public int Staff_PhoneNo
        {
            get { return staff_PhoneNo; }
            set { staff_PhoneNo = value; }
        }
        public string Staff_Email
        {
            get { return staff_Email; }
            set { staff_Email = value; }
        }
        public string StaffHomeAdd
        {
            get { return staffHomeAdd; }
            set { staffHomeAdd = value; }
        }
        public int Staff_PostalCode
        {
            get { return staff_PostalCode; }
            set { staff_PostalCode = value; }
        }
        public string Staff_CountryOrigin
        {
            get { return staff_CountryOrigin; }
            set { staff_CountryOrigin = value; }
        }
        public string Staff_Level
        {
            get { return staff_Level; }
            set { staff_Level = value; }
        }
    }
}
