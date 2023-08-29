﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pp_backend.Data;

#nullable disable

namespace pp_backend.Migrations
{
    [DbContext(typeof(mailDBContext))]
    [Migration("20230826043132_sixthCreate")]
    partial class sixthCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("pp_backend.models.HireMe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Browser")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Device")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("recievedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HireMe");
                });

            modelBuilder.Entity("pp_backend.models.VistiMe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Browser")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Device")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IpVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("recievedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("VisitMe");
                });
#pragma warning restore 612, 618
        }
    }
}
