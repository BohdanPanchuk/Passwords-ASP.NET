using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Passwords_ASP.NET.Models
{
    public class SiteContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }
    }
}