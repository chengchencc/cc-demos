using Chengchen.Demos.Host.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chengchen.Demos.Host.Domain.DataAccess
{
    public class AppDbContext : DbContext
    {
        #region properties
        public DbSet<Calendar> Calendars { get; set; }
        #endregion

        #region ctor
        public AppDbContext()
        { }
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
