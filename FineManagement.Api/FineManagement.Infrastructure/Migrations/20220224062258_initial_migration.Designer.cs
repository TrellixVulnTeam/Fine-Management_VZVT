﻿// <auto-generated />
using System;
using FineManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FineManagement.Infrastructure.Migrations
{
    [DbContext(typeof(FineManagementDbContext))]
    [Migration("20220224062258_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FineManagement.Core.Entities.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FineAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserTeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserTeamId");

                    b.ToTable("Fines", (string)null);
                });

            modelBuilder.Entity("FineManagement.Core.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams", (string)null);
                });

            modelBuilder.Entity("FineManagement.Core.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserTeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserTeamId");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("FineManagement.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FineManagement.Core.Entities.UserTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTeams", (string)null);
                });

            modelBuilder.Entity("FineManagement.Core.Entities.Fine", b =>
                {
                    b.HasOne("FineManagement.Core.Entities.UserTeam", "UserTeam")
                        .WithMany("Fines")
                        .HasForeignKey("UserTeamId");

                    b.Navigation("UserTeam");
                });

            modelBuilder.Entity("FineManagement.Core.Entities.Transaction", b =>
                {
                    b.HasOne("FineManagement.Core.Entities.UserTeam", "UserTeam")
                        .WithMany("Transactions")
                        .HasForeignKey("UserTeamId");

                    b.Navigation("UserTeam");
                });

            modelBuilder.Entity("FineManagement.Core.Entities.UserTeam", b =>
                {
                    b.HasOne("FineManagement.Core.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("FineManagement.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FineManagement.Core.Entities.UserTeam", b =>
                {
                    b.Navigation("Fines");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
