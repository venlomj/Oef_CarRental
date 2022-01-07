﻿// <auto-generated />
using System;
using CarRental_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRental_App.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    [Migration("20220106124435_ZevendeUpdate6Jan")]
    partial class ZevendeUpdate6Jan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRental_App.Models.Auto", b =>
                {
                    b.Property<int>("AutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutomodelID")
                        .HasColumnType("int");

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<string>("Kleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nummerplaat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutoID");

                    b.HasIndex("AutomodelID");

                    b.HasIndex("CategorieID");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("CarRental_App.Models.Automodel", b =>
                {
                    b.Property<int>("AutomodelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MerkID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutomodelID");

                    b.HasIndex("MerkID");

                    b.ToTable("Automodel");
                });

            modelBuilder.Entity("CarRental_App.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AantalDeuren")
                        .HasColumnType("int");

                    b.Property<int>("AantalZitplaatsen")
                        .HasColumnType("int");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PrijsPerDag")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CategorieID");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("CarRental_App.Models.Klant", b =>
                {
                    b.Property<int>("KlantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emailadres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gemeente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Huisnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationaliteit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoonnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("KlantID");

                    b.ToTable("Klant");
                });

            modelBuilder.Entity("CarRental_App.Models.Merk", b =>
                {
                    b.Property<int>("MerkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MerkNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MerkID");

                    b.ToTable("Merk");
                });

            modelBuilder.Entity("CarRental_App.Models.Reservatie", b =>
                {
                    b.Property<int>("ReservatieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Afleverdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Betaalmethode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KlantID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ophaaldatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservatieID");

                    b.HasIndex("KlantID");

                    b.ToTable("Reservatie");
                });

            modelBuilder.Entity("CarRental_App.Models.ReservatieCategorie", b =>
                {
                    b.Property<int>("ReservatieCategorieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<int>("ReservatieID")
                        .HasColumnType("int");

                    b.HasKey("ReservatieCategorieID");

                    b.HasIndex("CategorieID");

                    b.HasIndex("ReservatieID");

                    b.ToTable("ReservatieCategorieën");
                });

            modelBuilder.Entity("CarRental_App.Models.Auto", b =>
                {
                    b.HasOne("CarRental_App.Models.Automodel", "automodel")
                        .WithMany("Autos")
                        .HasForeignKey("AutomodelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental_App.Models.Categorie", "categorie")
                        .WithMany("Autos")
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental_App.Models.Automodel", b =>
                {
                    b.HasOne("CarRental_App.Models.Merk", "merk")
                        .WithMany("Automodellen")
                        .HasForeignKey("MerkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental_App.Models.Reservatie", b =>
                {
                    b.HasOne("CarRental_App.Models.Klant", "klant")
                        .WithMany("Reservaties")
                        .HasForeignKey("KlantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental_App.Models.ReservatieCategorie", b =>
                {
                    b.HasOne("CarRental_App.Models.Categorie", null)
                        .WithMany("ReservatieCategorieën")
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental_App.Models.Reservatie", null)
                        .WithMany("ReservatieCategorieën")
                        .HasForeignKey("ReservatieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
