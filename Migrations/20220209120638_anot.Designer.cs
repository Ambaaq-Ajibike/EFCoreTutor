﻿// <auto-generated />
using EfCoreTuto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreTuto.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220209120638_anot")]
    partial class anot
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

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("EfCoreTuto.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("EfCoreTuto.Book", b =>
                {
                    b.HasOne("EfCoreTuto.Publisher", "Publisher")
                        .WithMany("books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("EfCoreTuto.Publisher", b =>
                {
                    b.Navigation("books");
                });
#pragma warning restore 612, 618
        }
    }
}