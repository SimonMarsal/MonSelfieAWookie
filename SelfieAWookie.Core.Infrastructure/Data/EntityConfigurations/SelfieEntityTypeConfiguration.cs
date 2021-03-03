using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Core.Infrastructure.Data.EntityConfigurations
{
    class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {
        public void Configure(EntityTypeBuilder<Selfie> builder )
        {
            builder.ToTable("Selfie");
            builder.HasKey(h => h.Id);
            builder.HasOne(h => h.Wookie).WithMany(w => w.Selfies);
        }
    }
}
