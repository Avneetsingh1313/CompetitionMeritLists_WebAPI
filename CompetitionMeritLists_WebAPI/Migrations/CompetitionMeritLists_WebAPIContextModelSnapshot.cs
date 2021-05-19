﻿// <auto-generated />
using CompetitionMeritLists_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompetitionMeritLists_WebAPI.Migrations
{
    [DbContext(typeof(CompetitionMeritLists_WebAPIContext))]
    partial class CompetitionMeritLists_WebAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CompetitionMeritLists_WebAPI.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Marks_Obtained")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Student_age")
                        .HasColumnType("int");

                    b.Property<int>("Subject_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}