﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlakDukkaniApp.Context;

#nullable disable

namespace PlakDukkaniApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PlakDukkaniApp.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("IndirimOrani")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IndirimliFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SanatciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SanatciSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SatisiDevamEdiyorMu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Albumler");
                });

            modelBuilder.Entity("PlakDukkaniApp.Yonetici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yoneticiler");
                });
#pragma warning restore 612, 618
        }
    }
}
