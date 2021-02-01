﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPhoneBookDiary_MVC.Data;

namespace MyPhoneBookDiary_MVC.Migrations
{
    [DbContext(typeof(MyPhoneBookDiary_MVCContext))]
    partial class MyPhoneBookDiary_MVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.Address", b =>
                {
                    b.Property<int>("AddrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AddrId");

                    b.HasIndex("UserId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.Email", b =>
                {
                    b.Property<int>("EmailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ElectonicMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("EmailID");

                    b.HasIndex("UserId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LandLineNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isUsingWhatsApp")
                        .HasColumnType("bit");

                    b.HasKey("PhoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.Address", b =>
                {
                    b.HasOne("MyPhoneBookDiary_MVC.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.Email", b =>
                {
                    b.HasOne("MyPhoneBookDiary_MVC.Models.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.Phone", b =>
                {
                    b.HasOne("MyPhoneBookDiary_MVC.Models.User", "User")
                        .WithMany("Phones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyPhoneBookDiary_MVC.Models.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Emails");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}