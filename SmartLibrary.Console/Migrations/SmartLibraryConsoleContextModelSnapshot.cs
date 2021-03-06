﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartLibrary.ConsoleApp.Data;

namespace SmartLibrary.ConsoleApp.Migrations
{
    [DbContext(typeof(SmartLibraryConsoleContext))]
    partial class SmartLibraryConsoleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberId");

                    b.Property<string>("Tilte");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Memebers");
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.MemberCompetition", b =>
                {
                    b.Property<int>("MemberId");

                    b.Property<int>("CompetitionId");

                    b.HasKey("MemberId", "CompetitionId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("MemberCompetition");
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.MemberIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberId");

                    b.Property<string>("RealName");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("MemberIdentity");
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.Book", b =>
                {
                    b.HasOne("SmartLibrary.ConsoleApp.Domain.Member", "Member")
                        .WithMany("Books")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.MemberCompetition", b =>
                {
                    b.HasOne("SmartLibrary.ConsoleApp.Domain.Competition", "Competition")
                        .WithMany("Competitions")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SmartLibrary.ConsoleApp.Domain.Member", "Member")
                        .WithMany("Competitions")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SmartLibrary.ConsoleApp.Domain.MemberIdentity", b =>
                {
                    b.HasOne("SmartLibrary.ConsoleApp.Domain.Member")
                        .WithOne("MemberIdentity")
                        .HasForeignKey("SmartLibrary.ConsoleApp.Domain.MemberIdentity", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
