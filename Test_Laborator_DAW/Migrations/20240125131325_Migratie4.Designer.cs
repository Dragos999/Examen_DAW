﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Laborator_DAW.Data;

#nullable disable

namespace TestLaboratorDAW.Migrations
{
    [DbContext(typeof(myContext))]
    [Migration("20240125131325_Migratie4")]
    partial class Migratie4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test_Laborator_DAW.Models.Comanda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("id_utilizator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("utilizatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("utilizatorId");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.ComandaProdus", b =>
                {
                    b.Property<Guid>("id_comanda")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_produs")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id_comanda", "id_produs");

                    b.HasIndex("id_produs");

                    b.ToTable("ComandaProdus");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.Produs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pret")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.Utilizator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("varsta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Utilizator");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.Comanda", b =>
                {
                    b.HasOne("Test_Laborator_DAW.Models.Utilizator", "utilizator")
                        .WithMany("comenzi")
                        .HasForeignKey("utilizatorId");

                    b.Navigation("utilizator");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.ComandaProdus", b =>
                {
                    b.HasOne("Test_Laborator_DAW.Models.Comanda", "comanda")
                        .WithMany("produse")
                        .HasForeignKey("id_comanda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Laborator_DAW.Models.Produs", "produs")
                        .WithMany("comenzi")
                        .HasForeignKey("id_produs")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("comanda");

                    b.Navigation("produs");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.Comanda", b =>
                {
                    b.Navigation("produse");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.Produs", b =>
                {
                    b.Navigation("comenzi");
                });

            modelBuilder.Entity("Test_Laborator_DAW.Models.Utilizator", b =>
                {
                    b.Navigation("comenzi");
                });
#pragma warning restore 612, 618
        }
    }
}
