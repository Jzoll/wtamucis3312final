﻿// <auto-generated />
using Final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace wtamucis3312final.Migrations
{
    [DbContext(typeof(FinalDbContext))]
    partial class FinalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Final.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParkAbbreviation")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParkName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParkProperName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParkState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");
                });

            modelBuilder.Entity("Final.Models.UserData", b =>
                {
                    b.Property<int>("UserDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserDataId");

                    b.ToTable("UserData");
                });

            modelBuilder.Entity("Final.Models.UserNationalParks", b =>
                {
                    b.Property<int>("NationalParkId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("NationalParkId", "UserDataId");

                    b.HasIndex("UserDataId");

                    b.ToTable("UserNationalParks");
                });

            modelBuilder.Entity("Final.Models.UserNationalParks", b =>
                {
                    b.HasOne("Final.Models.NationalPark", "NationalPark")
                        .WithMany("UserNationalParks")
                        .HasForeignKey("NationalParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final.Models.UserData", "UserData")
                        .WithMany("UserNationalParks")
                        .HasForeignKey("UserDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NationalPark");

                    b.Navigation("UserData");
                });

            modelBuilder.Entity("Final.Models.NationalPark", b =>
                {
                    b.Navigation("UserNationalParks");
                });

            modelBuilder.Entity("Final.Models.UserData", b =>
                {
                    b.Navigation("UserNationalParks");
                });
#pragma warning restore 612, 618
        }
    }
}
