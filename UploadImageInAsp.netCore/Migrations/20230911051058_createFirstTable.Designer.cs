﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UploadImageInAsp.netCore.Data;

#nullable disable

namespace UploadImageInAsp.netCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230911051058_createFirstTable")]
    partial class createFirstTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UploadImageInAsp.netCore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "",
                            Name = "jaber"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "",
                            Name = "jaber"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "",
                            Name = "jaber"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
