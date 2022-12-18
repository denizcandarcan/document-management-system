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
    public class ClassOfDocConfiguration : IEntityTypeConfiguration<ClassOfDoc>
    {
        public void Configure(EntityTypeBuilder<ClassOfDoc> builder)
        {
            builder.Property(x=>x.Definition).IsRequired();
        }
    }
}
