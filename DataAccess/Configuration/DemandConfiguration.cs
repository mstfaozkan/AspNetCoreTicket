using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
    public class DemandConfiguration : IEntityTypeConfiguration<Demand>
    {
        public void Configure(EntityTypeBuilder<Demand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FromWhoId).IsRequired();
            builder.Property(x => x.FromWhoId).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Title).IsRequired();

            builder.ToTable("Demands");


        }
    }
}
