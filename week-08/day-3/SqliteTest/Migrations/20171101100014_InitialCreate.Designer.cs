﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using SqliteTest.Entities;
using System;

namespace SqliteTest.Migrations
{
    [DbContext(typeof(TestDataContext))]
    [Migration("20171101100014_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("SqliteTest.Models.TestData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsTrue");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("TestDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
