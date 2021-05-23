﻿// <auto-generated />
using System;
using BayMarch.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BayMarch.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210512132156_user")]
    partial class user
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BayMarch.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("BranchId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("GenUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ParamId")
                        .HasColumnType("bigint");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<long>("WareHouseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BayMarch.Models.Price", b =>
                {
                    b.Property<long>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GrantBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ItemPrice")
                        .HasColumnType("bigint");

                    b.Property<long>("PriceNum")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PriceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("BayMarch.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<long>("GlobalBarCode")
                        .HasColumnType("bigint");

                    b.Property<string>("GrantBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ItemNum")
                        .HasColumnType("bigint");

                    b.Property<long>("LocalBarCode")
                        .HasColumnType("bigint");

                    b.Property<long>("SourceID")
                        .HasColumnType("bigint");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TaxId")
                        .HasColumnType("bigint");

                    b.Property<float>("TaxValue")
                        .HasColumnType("real");

                    b.Property<bool>("Taxed")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BayMarch.Models.Seller", b =>
                {
                    b.Property<long>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("GrantBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SellerNum")
                        .HasColumnType("bigint");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SellerId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BayMarch.Models.Price", b =>
                {
                    b.HasOne("BayMarch.Models.Product", "ProductObj")
                        .WithMany("ItemPrices")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BayMarch.Models.Seller", "SellerObj")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductObj");

                    b.Navigation("SellerObj");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BayMarch.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BayMarch.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BayMarch.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BayMarch.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BayMarch.Models.Product", b =>
                {
                    b.Navigation("ItemPrices");
                });
#pragma warning restore 612, 618
        }
    }
}
