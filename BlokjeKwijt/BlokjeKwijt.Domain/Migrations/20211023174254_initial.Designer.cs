﻿// <auto-generated />
using System;
using BlokjeKwijt.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlokjeKwijt.Domain.Migrations
{
    [DbContext(typeof(BlokjeKwijtContext))]
    [Migration("20211023174254_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlokjeKwijt.Domain.Blokje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlockNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ColorID")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lenght")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfNobs")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ColorID");

                    b.ToTable("Blokjes");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.BlokjeColor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RgbValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BlokjeColors");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.ContactForm", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.UserHasExtraBrick", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlokjeID")
                        .HasColumnType("int");

                    b.Property<bool>("Solved")
                        .HasColumnType("bit");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BlokjeID");

                    b.HasIndex("UserID");

                    b.ToTable("UserHasExtraBricks");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.UserHasMissingBrick", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BLokjeID")
                        .HasColumnType("int");

                    b.Property<bool>("Solved")
                        .HasColumnType("bit");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BLokjeID");

                    b.HasIndex("UserID");

                    b.ToTable("UserHasMissingBricks");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.Blokje", b =>
                {
                    b.HasOne("BlokjeKwijt.Domain.BlokjeColor", "Color")
                        .WithMany()
                        .HasForeignKey("ColorID");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.ContactForm", b =>
                {
                    b.HasOne("BlokjeKwijt.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.UserHasExtraBrick", b =>
                {
                    b.HasOne("BlokjeKwijt.Domain.Blokje", "Blokje")
                        .WithMany()
                        .HasForeignKey("BlokjeID");

                    b.HasOne("BlokjeKwijt.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Blokje");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlokjeKwijt.Domain.UserHasMissingBrick", b =>
                {
                    b.HasOne("BlokjeKwijt.Domain.Blokje", "BLokje")
                        .WithMany()
                        .HasForeignKey("BLokjeID");

                    b.HasOne("BlokjeKwijt.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("BLokje");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
