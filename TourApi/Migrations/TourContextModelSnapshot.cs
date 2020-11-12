﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourApi.Data;

namespace TourApi.Migrations
{
    [DbContext(typeof(TourContext))]
    partial class TourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("TourApi.Models.Cost", b =>
                {
                    b.Property<int>("CostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CostName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CostId");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("TourApi.Models.CostDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CostDetailsName")
                        .HasColumnType("TEXT");

                    b.Property<int>("CostId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("TouristGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CostId");

                    b.HasIndex("TouristGroupId");

                    b.ToTable("CostDetails");
                });

            modelBuilder.Entity("TourApi.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirhth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdentityCardNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TourApi.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobName")
                        .HasColumnType("TEXT");

                    b.HasKey("JobId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("TourApi.Models.JobDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("JobId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("StaffId");

                    b.ToTable("JobDetails");
                });

            modelBuilder.Entity("TourApi.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("LocationName")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TourApi.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirhth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdentityCardNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("TourApi.Models.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("TourName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypesOfTourismId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TourId");

                    b.HasIndex("TypesOfTourismId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("TourApi.Models.TourDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InOrder")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("TourId");

                    b.ToTable("TourDetails");
                });

            modelBuilder.Entity("TourApi.Models.TourPrice", b =>
                {
                    b.Property<int>("TourPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TourPriceId");

                    b.HasIndex("TourId")
                        .IsUnique();

                    b.ToTable("TourPrice");
                });

            modelBuilder.Entity("TourApi.Models.TouristGroup", b =>
                {
                    b.Property<int>("TouristGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfMembers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ScheduleDetails")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TouristGroupId");

                    b.HasIndex("TourId");

                    b.ToTable("TouristGroup");
                });

            modelBuilder.Entity("TourApi.Models.TouristGroupDetailsOfCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TouristGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TouristGroupId");

                    b.ToTable("TouristGroupDetailsOfCustomer");
                });

            modelBuilder.Entity("TourApi.Models.TouristGroupDetailsOfStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TouristGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex("TouristGroupId");

                    b.ToTable("TouristGroupDetailsOfStaff");
                });

            modelBuilder.Entity("TourApi.Models.TypesOfTourism", b =>
                {
                    b.Property<int>("TypesOfTourismId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("TypesOfTourismId");

                    b.ToTable("TypesOfTourism");
                });

            modelBuilder.Entity("TourApi.Models.CostDetails", b =>
                {
                    b.HasOne("TourApi.Models.Cost", "Cost")
                        .WithMany("CostDetailsList")
                        .HasForeignKey("CostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApi.Models.TouristGroup", "TouristGroup")
                        .WithMany("CostDetailsList")
                        .HasForeignKey("TouristGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.JobDetails", b =>
                {
                    b.HasOne("TourApi.Models.Job", "Job")
                        .WithMany("JobDetailsList")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApi.Models.Staff", "Staff")
                        .WithMany("JobDetailsList")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.Tour", b =>
                {
                    b.HasOne("TourApi.Models.TypesOfTourism", "TypesOfTourism")
                        .WithMany("TourList")
                        .HasForeignKey("TypesOfTourismId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.TourDetails", b =>
                {
                    b.HasOne("TourApi.Models.Location", "Location")
                        .WithMany("TourDetailsList")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApi.Models.Tour", "Tour")
                        .WithMany("TourDetailsList")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.TourPrice", b =>
                {
                    b.HasOne("TourApi.Models.Tour", "Tour")
                        .WithOne("TourPrice")
                        .HasForeignKey("TourApi.Models.TourPrice", "TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.TouristGroup", b =>
                {
                    b.HasOne("TourApi.Models.Tour", "Tour")
                        .WithMany("TouristGroup")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.TouristGroupDetailsOfCustomer", b =>
                {
                    b.HasOne("TourApi.Models.Customer", "Customer")
                        .WithMany("TouristGroupDetailsOfCustomerList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApi.Models.TouristGroup", "TouristGroup")
                        .WithMany("TouristGroupDetailsOfCustomerList")
                        .HasForeignKey("TouristGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApi.Models.TouristGroupDetailsOfStaff", b =>
                {
                    b.HasOne("TourApi.Models.Staff", "Staff")
                        .WithMany("TouristGroupDetailsOfStaffList")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApi.Models.TouristGroup", "TouristGroup")
                        .WithMany("TouristGroupDetailsOfStaffList")
                        .HasForeignKey("TouristGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
