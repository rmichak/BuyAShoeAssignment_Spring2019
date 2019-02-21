using BuyAShoeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BuyAShoeAssignment.DAL
{
    public class ShoeStoreContext : DbContext
    {
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufactureres { get; set; }
    }
}