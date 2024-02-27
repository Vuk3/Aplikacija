﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace _4fit.Migrations
{
    [DbContext(typeof(_4fitContext))]
    partial class _4fitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Drzava")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fleg")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.Objava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojLajkova")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ID");

                    b.ToTable("Objava");
                });

            modelBuilder.Entity("Models.Paket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrajanjePaketa")
                        .HasColumnType("int");

                    b.Property<int?>("TrenerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TrenerID");

                    b.ToTable("Paket");
                });

            modelBuilder.Entity("Models.Pretplata", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumDo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumOd")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<int?>("PaketID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("PaketID");

                    b.ToTable("Pretplata");
                });

            modelBuilder.Entity("Models.Sertifikat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sertifikat");
                });

            modelBuilder.Entity("Models.SertifikatiTrenera", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GodinaDobijanja")
                        .HasColumnType("int");

                    b.Property<int?>("SertifikatID")
                        .HasColumnType("int");

                    b.Property<int?>("TrenerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SertifikatID");

                    b.HasIndex("TrenerID");

                    b.ToTable("SertifikatiTrenera");
                });

            modelBuilder.Entity("Models.Klijent", b =>
                {
                    b.HasBaseType("Models.Korisnik");

                    b.Property<string>("Zanimanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("Models.Trener", b =>
                {
                    b.HasBaseType("Models.Korisnik");

                    b.Property<string>("Biografija")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.ToTable("Trener");
                });

            modelBuilder.Entity("Models.NovaObjava", b =>
                {
                    b.HasBaseType("Models.Objava");

                    b.Property<int>("BrojKomentara")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasIndex("KorisnikID");

                    b.ToTable("NovaObjava");
                });

            modelBuilder.Entity("Models.ObjavaTrenera", b =>
                {
                    b.HasBaseType("Models.Objava");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrenerID")
                        .HasColumnType("int");

                    b.HasIndex("TrenerID");

                    b.ToTable("ObjavaTrenera");
                });

            modelBuilder.Entity("Models.OdgovorNaObjavu", b =>
                {
                    b.HasBaseType("Models.Objava");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("ObjavaID")
                        .HasColumnType("int");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ObjavaID");

                    b.ToTable("OdgovorNaObjavu");
                });

            modelBuilder.Entity("Models.Paket", b =>
                {
                    b.HasOne("Models.Trener", "Trener")
                        .WithMany("Paketi")
                        .HasForeignKey("TrenerID");

                    b.Navigation("Trener");
                });

            modelBuilder.Entity("Models.Pretplata", b =>
                {
                    b.HasOne("Models.Klijent", "Klijent")
                        .WithMany("Paketi")
                        .HasForeignKey("KlijentID");

                    b.HasOne("Models.Paket", "Paket")
                        .WithMany("Klijenti")
                        .HasForeignKey("PaketID");

                    b.Navigation("Klijent");

                    b.Navigation("Paket");
                });

            modelBuilder.Entity("Models.SertifikatiTrenera", b =>
                {
                    b.HasOne("Models.Sertifikat", "Sertifikat")
                        .WithMany("Treneri")
                        .HasForeignKey("SertifikatID");

                    b.HasOne("Models.Trener", "Trener")
                        .WithMany("Sertifikati")
                        .HasForeignKey("TrenerID");

                    b.Navigation("Sertifikat");

                    b.Navigation("Trener");
                });

            modelBuilder.Entity("Models.Klijent", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("Models.Klijent", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Trener", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("Models.Trener", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.NovaObjava", b =>
                {
                    b.HasOne("Models.Objava", null)
                        .WithOne()
                        .HasForeignKey("Models.NovaObjava", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("ObjaveNaForumu")
                        .HasForeignKey("KorisnikID");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.ObjavaTrenera", b =>
                {
                    b.HasOne("Models.Objava", null)
                        .WithOne()
                        .HasForeignKey("Models.ObjavaTrenera", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Models.Trener", "Trener")
                        .WithMany("Objave")
                        .HasForeignKey("TrenerID");

                    b.Navigation("Trener");
                });

            modelBuilder.Entity("Models.OdgovorNaObjavu", b =>
                {
                    b.HasOne("Models.Objava", null)
                        .WithOne()
                        .HasForeignKey("Models.OdgovorNaObjavu", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Odgovori")
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.NovaObjava", "Objava")
                        .WithMany("Odgovori")
                        .HasForeignKey("ObjavaID");

                    b.Navigation("Korisnik");

                    b.Navigation("Objava");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("ObjaveNaForumu");

                    b.Navigation("Odgovori");
                });

            modelBuilder.Entity("Models.Paket", b =>
                {
                    b.Navigation("Klijenti");
                });

            modelBuilder.Entity("Models.Sertifikat", b =>
                {
                    b.Navigation("Treneri");
                });

            modelBuilder.Entity("Models.Klijent", b =>
                {
                    b.Navigation("Paketi");
                });

            modelBuilder.Entity("Models.Trener", b =>
                {
                    b.Navigation("Objave");

                    b.Navigation("Paketi");

                    b.Navigation("Sertifikati");
                });

            modelBuilder.Entity("Models.NovaObjava", b =>
                {
                    b.Navigation("Odgovori");
                });
#pragma warning restore 612, 618
        }
    }
}
