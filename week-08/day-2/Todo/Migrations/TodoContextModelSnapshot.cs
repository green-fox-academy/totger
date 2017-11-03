﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TodoApp.Entities;

namespace TodoApp.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("TodoApp.Models.Todo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysRemaining");

                    b.Property<DateTime>("DueDate");

                    b.Property<bool>("IsDone");

                    b.Property<bool>("IsImportant");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Current");
                });
#pragma warning restore 612, 618
        }
    }
}
