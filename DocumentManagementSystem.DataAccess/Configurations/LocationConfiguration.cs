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
    internal class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(x => x.RoomNumber).HasMaxLength(20);
            builder.Property(x => x.ShelfNumber).HasMaxLength(20);


            builder.HasOne(x=>x.Borrower).WithMany(x=>x.Locations).HasForeignKey(x=>x.BorrowerId);
        }
    }
}
