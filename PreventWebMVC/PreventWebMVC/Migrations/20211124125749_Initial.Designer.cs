﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PreventWebMVC.Data;

namespace PreventWebMVC.Migrations
{
    [DbContext(typeof(PreventWebMVCContext))]
    [Migration("20211124125749_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PreventWebMVC.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Domain");

                    b.Property<string>("Ip");

                    b.Property<string>("Name");

                    b.Property<string>("OpSystem");

                    b.Property<string>("Processor");

                    b.Property<string>("Tag");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });
#pragma warning restore 612, 618
        }
    }
}
