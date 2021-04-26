﻿// <auto-generated />
using System;
using CoffeeRoastManagement.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoffeeRoastManagement.Server.Migrations
{
    [DbContext(typeof(RoastDbContext))]
    partial class RoastDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<byte[]>("FavIcon")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Cupping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cupping");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.GreenBeanInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<int>("Crop")
                        .HasColumnType("integer");

                    b.Property<string>("Farmer")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<double>("OverallCuppingScore")
                        .HasColumnType("double precision");

                    b.Property<string>("Processing")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.Property<string>("Variety")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GreenBeanInfo");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.GreenBlend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<int?>("RoastId")
                        .HasColumnType("integer");

                    b.Property<int?>("StockItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoastId");

                    b.HasIndex("StockItemId");

                    b.ToTable("GreenBlend");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Roast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CuppingInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Equipment")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("RoastProfile")
                        .HasColumnType("jsonb");

                    b.Property<string>("ShortInfo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CuppingInfoId");

                    b.ToTable("Roast");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<bool>("BeansAvailable")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("GoodsReceived")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("GreenBeanInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<double>("OverallPrice")
                        .HasColumnType("double precision");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<int?>("SellerContactId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GreenBeanInfoId");

                    b.HasIndex("SellerContactId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.GreenBlend", b =>
                {
                    b.HasOne("CoffeeRoastManagement.Shared.Entities.Roast", null)
                        .WithMany("Beans")
                        .HasForeignKey("RoastId");

                    b.HasOne("CoffeeRoastManagement.Shared.Entities.Stock", "StockItem")
                        .WithMany()
                        .HasForeignKey("StockItemId");

                    b.Navigation("StockItem");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Roast", b =>
                {
                    b.HasOne("CoffeeRoastManagement.Shared.Entities.Cupping", "CuppingInfo")
                        .WithMany()
                        .HasForeignKey("CuppingInfoId");

                    b.Navigation("CuppingInfo");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Stock", b =>
                {
                    b.HasOne("CoffeeRoastManagement.Shared.Entities.GreenBeanInfo", "GreenBeanInfo")
                        .WithMany()
                        .HasForeignKey("GreenBeanInfoId");

                    b.HasOne("CoffeeRoastManagement.Shared.Entities.Contact", "SellerContact")
                        .WithMany()
                        .HasForeignKey("SellerContactId");

                    b.Navigation("GreenBeanInfo");

                    b.Navigation("SellerContact");
                });

            modelBuilder.Entity("CoffeeRoastManagement.Shared.Entities.Roast", b =>
                {
                    b.Navigation("Beans");
                });
#pragma warning restore 612, 618
        }
    }
}
