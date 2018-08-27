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

    }
}