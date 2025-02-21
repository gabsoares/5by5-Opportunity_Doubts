﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpportunityApi.Data;

#nullable disable

namespace OpportunityApi.Migrations
{
    [DbContext(typeof(OpportunityApiContext))]
    [Migration("20240606185940_InitialCreated")]
    partial class InitialCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ErrorsAmount")
                        .HasColumnType("bigint");

                    b.Property<int>("HoursAmount")
                        .HasColumnType("int");

                    b.Property<long>("LearningLevel")
                        .HasColumnType("bigint");

                    b.Property<int>("OffHours")
                        .HasColumnType("int");

                    b.Property<long>("SleepHours")
                        .HasColumnType("bigint");

                    b.Property<string>("SurgeLevel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Opportunity");
                });
#pragma warning restore 612, 618
        }
    }
}
