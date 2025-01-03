﻿// <auto-generated />
using System;
using AuctionService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuctionService.Data.Migrations
{
    [DbContext(typeof(AuctionDbContext))]
    [Migration("20241222231223_Annotations")]
    partial class Annotations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuctionService.Entities.Auction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("AuctionEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("auction_end");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CurrentHighBid")
                        .HasColumnType("integer")
                        .HasColumnName("current_high_bid");

                    b.Property<int>("ReservedPrice")
                        .HasColumnType("integer")
                        .HasColumnName("reserved_price");

                    b.Property<string>("Seller")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("seller");

                    b.Property<int>("SoldAmount")
                        .HasColumnType("integer")
                        .HasColumnName("sold_amount");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Winner")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("winner");

                    b.HasKey("Id");

                    b.ToTable("auctions");
                });

            modelBuilder.Entity("AuctionService.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uuid")
                        .HasColumnName("auction_id");

                    b.Property<string>("Color")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("color");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("image_url");

                    b.Property<string>("Make")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("make");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer")
                        .HasColumnName("mileage");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("model");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.ToTable("items");
                });

            modelBuilder.Entity("AuctionService.Entities.Item", b =>
                {
                    b.HasOne("AuctionService.Entities.Auction", "Auction")
                        .WithOne("Item")
                        .HasForeignKey("AuctionService.Entities.Item", "AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("AuctionService.Entities.Auction", b =>
                {
                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}