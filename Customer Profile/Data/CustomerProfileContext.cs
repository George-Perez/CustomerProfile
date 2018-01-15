using CustomerProfile.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerProfile.Data
{
    public class CustomerProfileContext : DbContext
    {
        public CustomerProfileContext() : base("CustomerProfile")
        {

        }
        public DbSet<CustomerProfileModel> CustomerProfiles { get; set; }
    }
   
}