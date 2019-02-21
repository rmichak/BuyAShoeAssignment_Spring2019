using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyAShoeAssignment.Models
{
    public class Shoe
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal UnitCost { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantityOnOrder { get; set; }
        public bool OnSale { get; set; }
        public DateTime DateReleased { get; set; }
        public int ManufacturerID { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}