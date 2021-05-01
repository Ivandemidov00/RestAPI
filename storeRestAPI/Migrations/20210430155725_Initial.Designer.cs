﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using storeRestAPI.Context;

namespace storeRestAPI.Migrations
{
    [DbContext(typeof(storeContext))]
    [Migration("20210430155725_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("storeRestAPI.Model.order", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<short>("Amount")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<short>("IdProduct")
                        .HasColumnType("smallint");

                    b.Property<short>("IdUser")
                        .HasColumnType("smallint");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<short?>("productId")
                        .HasColumnType("smallint");

                    b.Property<short?>("userId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.HasIndex("userId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("storeRestAPI.Model.product", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<short>("AmountAvailability")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("storeRestAPI.Model.user", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("storeRestAPI.Model.order", b =>
                {
                    b.HasOne("storeRestAPI.Model.product", "product")
                        .WithMany("orders")
                        .HasForeignKey("productId");

                    b.HasOne("storeRestAPI.Model.user", "user")
                        .WithMany("orders")
                        .HasForeignKey("userId");

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("storeRestAPI.Model.product", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("storeRestAPI.Model.user", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
