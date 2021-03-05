using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Core.Infrastructure.Data.EntityConfigurations
{
    class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>
    {
        public void Configure(EntityTypeBuilder<Wookie> builder )
        {
            builder.ToTable("Wookie");
            builder.HasKey(h => h.Id);
            builder.Ignore(i => i.SecondaryWeapons);
            builder.Property(p => p.Prenom).IsRequired(true);
        }
    }
}
