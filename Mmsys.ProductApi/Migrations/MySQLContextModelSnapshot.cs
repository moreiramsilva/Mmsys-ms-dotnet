﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmsys.ProductManagementApi.Model.Context;

#nullable disable

namespace Mmsys.ProductManagementApi.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mmsys.ProductApi.Model.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<string>("CompanyImage")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("company_image_url");

                    b.Property<decimal>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Mmsys.ProductApi.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint")
                        .HasColumnName("companyId");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}
