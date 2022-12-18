using DocumentManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.DataAccess.Configurations
{
    public class AppUserDocumentConfiguration : IEntityTypeConfiguration<AppUserDocument>
    {
        public void Configure(EntityTypeBuilder<AppUserDocument> builder)
        {
            builder.HasIndex(x => new
            {
                x.AppUserId,
                x.DocumentId
            }).IsUnique();

            builder.HasOne(x=>x.AppUser).WithMany(x=>x.AppUserDocuments).HasForeignKey(x=>x.AppUserId);
            builder.HasOne(x => x.Document).WithMany(x => x.AppUserDocuments).HasForeignKey(x => x.DocumentId);


        }
    }
}
