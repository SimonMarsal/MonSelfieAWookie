using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Core.Infrastructure.Data.EntityConfigurations
{
    class WeaponEntityTypeConfiguration : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder )
        {
            builder.ToTable("Weapon");
            builder.HasKey(h => h.Id);
        }
    }
}
