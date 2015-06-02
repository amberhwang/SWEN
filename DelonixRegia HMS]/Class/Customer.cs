using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class Customer
    {
        private string cusID;
        private string f_Name;
        private string l_Name;
        private int phone_No;
        private string email;
        private string street_Add;
        private string block_No;
        private string house_No;
        private string postal_Code;
        private string country_Origin;

        public Customer(string cusID, string f_Name, string l_Name, int phone_No, string email, string street_Add, string block_No, string house_No, string postal_Code, string country_Origin)
        {
            this.cusID = cusID;
            this.f_Name = f_Name;
            this.l_Name = l_Name;
            this.phone_No = phone_No;
            this.email = email;
            this.street_Add = street_Add;
            this.block_No = block_No;
            this.house_No = house_No;
            this.postal_Code = postal_Code;
            this.country_Origin = country_Origin;
        }
        public Customer()
        {

        }

        public string CusID
        {
            get { return cusID; }
            set { cusID = value; }
        }

        public string F_Name
        {
            get { return f_Name; }
            set { f_Name = value; }
        }

        public string L_Name
        {
            get { return l_Name; }
            set { l_Name = value; }
        }

        public int Phone_No
        {
            get { return phone_No; }
            set { phone_No = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Street_Add
        {
            get { return street_Add; }
            set { street_Add = value; }
        }

        public string Block_No
        {
            get { return block_No; }
            set { block_No = value; }
        }

        public string House_No
        {
            get { return house_No; }
            set { house_No = value; }
        }

        public string Postal_Code
        {
            get { return postal_Code; }
            set { postal_Code = value; }
        }
        public string Country_Origin
        {
            get { return country_Origin; }
            set { country_Origin = value; }
        }
    }
}
