using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmoApp.Models
{
    public class UserDetails
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime dateofBirth { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string Address_Line3 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string EmailID { get; set; }
        public string PersonalPhone { get; set; }
        public string WorkPhone { get; set; }
        public DateTime Begin_date { get; set; }
        public DateTime End_Date { get; set; }
    }
}