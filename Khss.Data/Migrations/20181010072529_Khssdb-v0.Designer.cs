﻿// <auto-generated />
using System;
using KhssData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KhssData.Migrations
{
    [DbContext(typeof(KhssContext))]
    [Migration("20181010072529_Khssdb-v0")]
    partial class Khssdbv0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KhssData.DomainModels.Attendance.Attendance", b =>
                {
                    b.Property<int>("AttendaceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AttendanceDate");

                    b.Property<string>("AttendanceType")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("StudentClassId");

                    b.HasKey("AttendaceId");

                    b.HasIndex("StudentClassId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("KhssData.DomainModels.Attendance.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("KhssData.DomainModels.Attendance.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("SectionName");

                    b.HasKey("SectionId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("KhssData.DomainModels.Attendance.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Phone");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("KhssData.DomainModels.Attendance.StudentClass", b =>
                {
                    b.Property<int>("StudentClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("SectionId");

                    b.Property<int?>("StudentId");

                    b.HasKey("StudentClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SectionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentClasses");
                });

            modelBuilder.Entity("KhssData.DomainModels.Attendance.Attendance", b =>
                {
                    b.HasOne("KhssData.DomainModels.Attendance.StudentClass", "StudentClass")
                        .WithMany()
                        .HasForeignKey("StudentClassId");
                });

            modelBuilder.Entity("KhssData.DomainModels.Attendance.StudentClass", b =>
                {
                    b.HasOne("KhssData.DomainModels.Attendance.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("KhssData.DomainModels.Attendance.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");

                    b.HasOne("KhssData.DomainModels.Attendance.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}