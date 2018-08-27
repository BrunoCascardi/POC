﻿using Cascardi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Cascardi.DAL
{
    public class CascardiContext : DbContext
    {
        public CascardiContext()
            : base("CascardiContext")
        {
        }

        //public IDbSet<Team> Teams { get; set; }
        public IDbSet<Customer> Customers { get; set; }
    }
}