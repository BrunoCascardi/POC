using Cascardi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cascardi.DAL
{
    public class CascardiInitializer :  DropCreateDatabaseIfModelChanges<CascardiContext>
    {
        protected override void Seed(CascardiContext context)
        {
            var vendor = new Vendor()
            {
                FirstName = "Seed",
                LastName = "Last",
                Address = "Rua",
                BirthDate = DateTime.Now,
                Email = "br@pt.com"
            };

            context.Vendors.Add(vendor);
            base.Seed(context); 
        }
    }
}