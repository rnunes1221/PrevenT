﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PreventWebMVC.Data;

namespace PreventWebMVC.Migrations
{
    [DbContext(typeof(PreventWebMVCContext))]
    [Migration("20211129235404_Authentication")]
    partial class Authentication
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

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("OpSystem");

                    b.Property<string>("Processor");

                    b.Property<string>("Tag");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("PreventWebMVC.Models.Prev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComputerId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Obs");

                    b.HasKey("Id");

                    b.HasIndex("ComputerId");

                    b.ToTable("Prev");
                });

            modelBuilder.Entity("PreventWebMVC.Models.Prev", b =>
                {
                    b.HasOne("PreventWebMVC.Models.Computer", "Computer")
                        .WithMany("Prevs")
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
