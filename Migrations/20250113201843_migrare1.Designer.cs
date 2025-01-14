﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect3._0.Data;

#nullable disable

namespace Proiect3._0.Migrations
{
    [DbContext(typeof(Proiect3_0Context))]
    [Migration("20250113201843_migrare1")]
    partial class migrare1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect3._0.Models.Locatia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DenumireLocatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locatia");
                });

            modelBuilder.Entity("Proiect3._0.Models.Regizor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NumeRegizor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Regizor");
                });

            modelBuilder.Entity("Proiect3._0.Models.Spectacol", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataSpectacol")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocatiaID")
                        .HasColumnType("int");

                    b.Property<int?>("RegizorID")
                        .HasColumnType("int");

                    b.Property<int?>("TipID")
                        .HasColumnType("int");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LocatiaID");

                    b.HasIndex("RegizorID");

                    b.HasIndex("TipID");

                    b.ToTable("Spectacol");
                });

            modelBuilder.Entity("Proiect3._0.Models.Tip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DenumireTip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tip");
                });

            modelBuilder.Entity("Proiect3._0.Models.Spectacol", b =>
                {
                    b.HasOne("Proiect3._0.Models.Locatia", "Locatia")
                        .WithMany("Spectacole")
                        .HasForeignKey("LocatiaID");

                    b.HasOne("Proiect3._0.Models.Regizor", "Regizor")
                        .WithMany("Spectacole")
                        .HasForeignKey("RegizorID");

                    b.HasOne("Proiect3._0.Models.Tip", "Tip")
                        .WithMany("Spectacole")
                        .HasForeignKey("TipID");

                    b.Navigation("Locatia");

                    b.Navigation("Regizor");

                    b.Navigation("Tip");
                });

            modelBuilder.Entity("Proiect3._0.Models.Locatia", b =>
                {
                    b.Navigation("Spectacole");
                });

            modelBuilder.Entity("Proiect3._0.Models.Regizor", b =>
                {
                    b.Navigation("Spectacole");
                });

            modelBuilder.Entity("Proiect3._0.Models.Tip", b =>
                {
                    b.Navigation("Spectacole");
                });
#pragma warning restore 612, 618
        }
    }
}
