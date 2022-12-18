using DocumentManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.DataAccess.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Username).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(25).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(10).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(15).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(70).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();

            builder.HasOne(x => x.Department).WithMany(x => x.AppUsers).HasForeignKey(x => x.DeparmentId);

        }
    }
}
