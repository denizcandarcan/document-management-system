using DocumentManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.DataAccess.Configurations
{
    internal class TypeOfDocConfiguration : IEntityTypeConfiguration<TypeOfDoc>
    {
        public void Configure(EntityTypeBuilder<TypeOfDoc> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(35).IsRequired();
        }
    }
}
