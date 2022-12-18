using DocumentManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.DataAccess.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(x=> x.Title).IsRequired();
            builder.Property(x=> x.Description).HasColumnType("ntext").IsRequired();
            builder.Property(x=> x.DocState).IsRequired();
            builder.Property(x=> x.SendDate).IsRequired();


            builder.HasOne(x => x.ClassOfDoc).WithMany(x => x.Documents).HasForeignKey(x => x.ClassOfDocId);
            builder.HasOne(x => x.TypeOfDoc).WithMany(x => x.Documents).HasForeignKey(x => x.TypeDocId);
            builder.HasOne(d => d.Location).WithOne(l => l.Document).HasForeignKey<Location>(l => l.DocumentId); // chatgbt
        }
    }
}
