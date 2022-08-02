﻿// <auto-generated />
using EfCoreTuto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreTuto.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220209090111_thir")]
    partial class thir
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("EfCoreTuto.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
