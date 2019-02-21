using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyAShoeAssignment.Models
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
    }
}