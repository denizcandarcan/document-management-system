﻿// <auto-generated />
using System;
using DocumentManagementSystem.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocumentManagementSystem.DataAccess.Migrations
{
    [DbContext(typeof(DocumentContext))]
    [Migration("20221218171052_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeparmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("DeparmentId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUserDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("RoleOfUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("DocumentId");

                    b.ToTable("AppUserDocuments");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("AppUserId", "AppRoleId")
                        .IsUnique();

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.ClassOfDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClassOfDocs");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassOfDocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("DocState")
                        .HasColumnType("int");

                    b.Property<int>("DocStatus")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReceiveDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReplyDocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeDocId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassOfDocId");

                    b.HasIndex("TypeDocId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BorrowerId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ShelfNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("isBorrowed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BorrowerId");

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.TypeOfDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfDocs");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUser", b =>
                {
                    b.HasOne("DocumentManagementSystem.Entities.Department", "Department")
                        .WithMany("AppUsers")
                        .HasForeignKey("DeparmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUserDocument", b =>
                {
                    b.HasOne("DocumentManagementSystem.Entities.AppUser", "AppUser")
                        .WithMany("AppUserDocuments")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentManagementSystem.Entities.Document", "Document")
                        .WithMany("AppUserDocuments")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Document");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUserRole", b =>
                {
                    b.HasOne("DocumentManagementSystem.Entities.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentManagementSystem.Entities.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Document", b =>
                {
                    b.HasOne("DocumentManagementSystem.Entities.ClassOfDoc", "ClassOfDoc")
                        .WithMany("Documents")
                        .HasForeignKey("ClassOfDocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentManagementSystem.Entities.TypeOfDoc", "TypeOfDoc")
                        .WithMany("Documents")
                        .HasForeignKey("TypeDocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassOfDoc");

                    b.Navigation("TypeOfDoc");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Location", b =>
                {
                    b.HasOne("DocumentManagementSystem.Entities.AppUser", "Borrower")
                        .WithMany("Locations")
                        .HasForeignKey("BorrowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentManagementSystem.Entities.Document", "Document")
                        .WithOne("Location")
                        .HasForeignKey("DocumentManagementSystem.Entities.Location", "DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borrower");

                    b.Navigation("Document");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppRole", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.AppUser", b =>
                {
                    b.Navigation("AppUserDocuments");

                    b.Navigation("AppUserRoles");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.ClassOfDoc", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Department", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.Document", b =>
                {
                    b.Navigation("AppUserDocuments");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DocumentManagementSystem.Entities.TypeOfDoc", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
