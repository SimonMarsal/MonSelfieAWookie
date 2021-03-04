using Microsoft.EntityFrameworkCore;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SelfieAWookie.Core.Infrastructure.Data
{
    public class SelfieAWookieDbContext : DbContext
    {
        protected SelfieAWookieDbContext()
        {
        }

        public SelfieAWookieDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Selfie>(new EntityConfigurations.SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Wookie>(new EntityConfigurations.WookieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Weapon>(new EntityConfigurations.WeaponEntityTypeConfiguration());
        }

        #region Properties
        public DbSet<Wookie> Woookies { get; set; }
        public DbSet<Selfie> Selfies { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        #endregion
    }
}
