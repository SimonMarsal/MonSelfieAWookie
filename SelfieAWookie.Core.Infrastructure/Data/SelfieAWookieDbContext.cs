using Microsoft.EntityFrameworkCore;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Core.Infrastructure.Data
{
    public class SelfieAWookieDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Selfie>(new EntityConfigurations.SelfieEntityTypeConfiguration());
        }

        #region Properties
        public DbSet<Wookie> Woookies { get; set; }
        public DbSet<Selfie> Selfies { get; set; }
        #endregion
    }
}
