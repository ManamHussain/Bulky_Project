﻿// <auto-generated />
using Bulky_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240604101831_AddSeedCategoryTable")]
    partial class AddSeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky_Project.Models.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderDisplay")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Action",
                            OrderDisplay = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Clothes",
                            OrderDisplay = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Jeans",
                            OrderDisplay = 3
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Shirts",
                            OrderDisplay = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Shoes",
                            OrderDisplay = 5
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Hudies",
                            OrderDisplay = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
