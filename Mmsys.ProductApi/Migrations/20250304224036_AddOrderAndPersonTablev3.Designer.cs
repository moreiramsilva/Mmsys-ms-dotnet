﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mmsys.ProductManagementApi.Model.Context;

#nullable disable

namespace Mmsys.ProductManagementApi.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20250304224036_AddOrderAndPersonTablev3")]
    partial class AddOrderAndPersonTablev3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mmsys.ProductManagementApi.Model.DAO.Company", b =>
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

            modelBuilder.Entity("Mmsys.ProductManagementApi.Model.DAO.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date_time");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("payment_type");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person_id");

                    b.HasKey("Id");

                    b.ToTable("order");
                });

            modelBuilder.Entity("Mmsys.ProductManagementApi.Model.DAO.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("address");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint")
                        .HasColumnName("company_id");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("cpf_cnpj");

                    b.Property<long>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("bigint")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Image")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("PersonType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("person_type");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone");

                    b.Property<string>("RegistrationType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("registration_type");

                    b.HasKey("Id");

                    b.ToTable("person");
                });

            modelBuilder.Entity("Mmsys.ProductManagementApi.Model.DAO.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint")
                        .HasColumnName("company_id");

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
