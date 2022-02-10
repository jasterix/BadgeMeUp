﻿// <auto-generated />
using System;
using BadgeMeUp.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BadgeMeUp.Migrations
{
    [DbContext(typeof(BadgeContext))]
    [Migration("20220209194740_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BadgeMeUp.Models.AssignedBadge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AwardComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BadgeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAssigned")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FromUserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.HasIndex("FromUserId");

                    b.HasIndex("UserId");

                    b.ToTable("AssignedBadges");
                });

            modelBuilder.Entity("BadgeMeUp.Models.Badge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BadgeTypeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("BannerImageBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("BannerImageContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Criteria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BadgeTypeId");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("BadgeMeUp.Models.BadgeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BadgeTypes");
                });

            modelBuilder.Entity("BadgeMeUp.Models.EmailQueue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailQueue");
                });

            modelBuilder.Entity("BadgeMeUp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("PrincipalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PrincipalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BadgeMeUp.Models.AssignedBadge", b =>
                {
                    b.HasOne("BadgeMeUp.Models.Badge", "Badge")
                        .WithMany()
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BadgeMeUp.Models.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BadgeMeUp.Models.User", "User")
                        .WithMany("AssignedBadges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Badge");

                    b.Navigation("FromUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BadgeMeUp.Models.Badge", b =>
                {
                    b.HasOne("BadgeMeUp.Models.BadgeType", "BadgeType")
                        .WithMany()
                        .HasForeignKey("BadgeTypeId");

                    b.Navigation("BadgeType");
                });

            modelBuilder.Entity("BadgeMeUp.Models.User", b =>
                {
                    b.Navigation("AssignedBadges");
                });
#pragma warning restore 612, 618
        }
    }
}
