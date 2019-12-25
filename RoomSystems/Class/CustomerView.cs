using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static RoomSystems.Class.ClassDO;

namespace RoomSystems.Class
{
    public class CustomerView
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public byte[] image { get; set; }
        public string nation { get; set; }
        public string region { get; set; }
        public string idcard { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string passport { get; set; }

        public CustomerView()
        {

        }
        public CustomerView(string name, string gender, int age, byte[] image, string nation, string region, string idcard, string phone, string address, string passport)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.image = image;
            this.nation = nation;
            this.region = region;
            this.idcard = idcard;
            this.passport = passport;
            this.phone = phone;
            this.address = address;
        }
        //
        
    }
}
