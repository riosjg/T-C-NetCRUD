using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using back.Models;

namespace back.DAL
{
    public class TCDbContext : DbContext
    {
        public TCDbContext() : base("TCDB")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}