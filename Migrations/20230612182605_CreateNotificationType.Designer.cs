﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SharedLibrary;

#nullable disable

namespace SharedLibrary.Migrations
{
    [DbContext(typeof(DlhDbContext))]
    [Migration("20230612182605_CreateNotificationType")]
    partial class CreateNotificationType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IzinAngkutKendaraan", b =>
                {
                    b.Property<Guid>("IzinAngkutsIzinAngkutID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("KendaraansKendaraanID")
                        .HasColumnType("uuid");

                    b.HasKey("IzinAngkutsIzinAngkutID", "KendaraansKendaraanID");

                    b.HasIndex("KendaraansKendaraanID");

                    b.ToTable("IzinAngkutKendaraan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kabupaten", b =>
                {
                    b.Property<string>("KabupatenID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<bool>("IsKota")
                        .HasColumnType("boolean");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaKabupaten")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("ProvinsiID")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("KabupatenID");

                    b.HasIndex("ProvinsiID");

                    b.ToTable("Kabupaten");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kecamatan", b =>
                {
                    b.Property<string>("KecamatanID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("KabupatenID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaKecamatan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("KecamatanID");

                    b.HasIndex("KabupatenID");

                    b.ToTable("Kecamatan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kelurahan", b =>
                {
                    b.Property<string>("KelurahanID")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("KecamatanID")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaKelurahan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("KelurahanID");

                    b.HasIndex("KecamatanID");

                    b.ToTable("Kelurahan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Provinsi", b =>
                {
                    b.Property<string>("ProvinsiID")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("HcKey")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("KodeNegara")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NamaProvinsi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ProvinsiID");

                    b.ToTable("Provinsi");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.Client", b =>
                {
                    b.Property<Guid>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ClientName")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsB2B")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.ClientPkm", b =>
                {
                    b.Property<Guid>("ClientPkmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alamat")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DokumenKTP")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("DokumenNIB")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("DokumenNPWP")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Fax")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<bool>("IsAngkut")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOlah")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUsaha")
                        .HasColumnType("boolean");

                    b.Property<string>("KelurahanID")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("NIB")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("NPWP")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NoHpPIC")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("PIC")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("character varying(75)");

                    b.Property<string>("PenanggungJawab")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("character varying(75)");

                    b.Property<string>("Telp")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserEmail")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("ClientPkmID");

                    b.HasIndex("ClientID")
                        .IsUnique();

                    b.HasIndex("KelurahanID");

                    b.ToTable("ClientPkm");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.LokasiBuang", b =>
                {
                    b.Property<int>("LokasiBuangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LokasiBuangID"));

                    b.Property<string>("NamaLokasi")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("LokasiBuangID");

                    b.ToTable("LokasiBuang");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.LokasiIzin", b =>
                {
                    b.Property<int>("LokasiIzinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LokasiIzinID"));

                    b.Property<string>("NamaLokasi")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("LokasiIzinID");

                    b.ToTable("LokasiIzin");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.NotificationType", b =>
                {
                    b.Property<int>("NotificationTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("NotificationTypeID"));

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("NotificationTypeID");

                    b.ToTable("NotificationType");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatusID"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Kawasan.JenisIzinLingkungan", b =>
                {
                    b.Property<int>("JenisIzinLingkunganID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("JenisIzinLingkunganID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NamaJenisIzin")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("JenisIzinLingkunganID");

                    b.ToTable("JenisIzinLingkungan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Kawasan.JenisKegiatan", b =>
                {
                    b.Property<int>("JenisKegiatanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("JenisKegiatanID"));

                    b.Property<bool?>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("NamaKegiatan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("JenisKegiatanID");

                    b.ToTable("JenisKegiatan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Timbangan.Transaction", b =>
                {
                    b.Property<long>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("TransactionID"));

                    b.Property<string>("AreaKerja")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("BeratKeluar")
                        .HasColumnType("integer");

                    b.Property<int>("BeratMasuk")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(75)
                        .HasColumnType("character varying(75)");

                    b.Property<DateTime>("InDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("IsPasar")
                        .HasColumnType("boolean");

                    b.Property<TimeOnly?>("JamKeluar")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("JamMasuk")
                        .HasColumnType("time without time zone");

                    b.Property<Guid>("KendaraanID")
                        .HasColumnType("uuid");

                    b.Property<string>("NoPintu")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("NoPolisi")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime?>("OutDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Penugasan")
                        .HasMaxLength(75)
                        .HasColumnType("character varying(75)");

                    b.Property<string>("RFID")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int?>("StatusID")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("TglKeluar")
                        .HasColumnType("date");

                    b.Property<DateOnly>("TglMasuk")
                        .HasColumnType("date");

                    b.Property<Guid>("TransactionGUID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("TransactionID");

                    b.HasIndex("KendaraanID");

                    b.HasIndex("StatusID");

                    b.ToTable("Pemimbangan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.DokumenKendaraan", b =>
                {
                    b.Property<Guid>("DokumenKendaraanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BuktiUjiEmisi")
                        .HasColumnType("text");

                    b.Property<string>("DokumenKIR")
                        .HasColumnType("text");

                    b.Property<string>("DokumenSTNK")
                        .HasColumnType("text");

                    b.Property<string>("FotoKendaraan")
                        .HasColumnType("text");

                    b.Property<Guid>("KendaraanID")
                        .HasColumnType("uuid");

                    b.Property<string>("TahunPembuatan")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)");

                    b.Property<DateOnly>("TglKIR")
                        .HasColumnType("date");

                    b.Property<DateOnly>("TglSTNK")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("TglUjiEmisi")
                        .HasColumnType("date");

                    b.HasKey("DokumenKendaraanID");

                    b.HasIndex("KendaraanID")
                        .IsUnique();

                    b.ToTable("DokumenKendaraan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.IzinAngkut", b =>
                {
                    b.Property<Guid>("IzinAngkutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DokumenIzin")
                        .HasColumnType("text");

                    b.Property<int>("JmlAngkutan")
                        .HasColumnType("integer");

                    b.Property<int?>("LokasiBuangID")
                        .HasColumnType("integer");

                    b.Property<int>("LokasiIzinID")
                        .HasColumnType("integer");

                    b.Property<string>("NoIzinUsaha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateOnly>("TglAkhirIzin")
                        .HasColumnType("date");

                    b.Property<DateOnly>("TglTerbitIzin")
                        .HasColumnType("date");

                    b.Property<Guid>("UniqueID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("IzinAngkutID");

                    b.HasIndex("ClientID");

                    b.HasIndex("LokasiBuangID");

                    b.HasIndex("LokasiIzinID");

                    b.ToTable("IzinAngkut");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.Kendaraan", b =>
                {
                    b.Property<Guid>("KendaraanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AlasanBlokir")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("AreaKerja")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int?>("BeratKIR")
                        .HasColumnType("integer");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("IsPasar")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("NoPintu")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("NoPolisi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("RFID")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<int>("StatusID")
                        .HasColumnType("integer");

                    b.Property<int>("TipeKendaraanID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("KendaraanID");

                    b.HasIndex("ClientID");

                    b.HasIndex("StatusID");

                    b.HasIndex("TipeKendaraanID");

                    b.ToTable("Kendaraan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.LokasiAngkut", b =>
                {
                    b.Property<Guid>("LokasiAngkutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DokumenPath")
                        .HasColumnType("text");

                    b.Property<bool?>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<Guid>("KawasanID")
                        .HasColumnType("uuid");

                    b.Property<string>("NamaLokasi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateOnly>("TglAkhirKontrak")
                        .HasColumnType("date");

                    b.Property<DateOnly>("TglAwalKontrak")
                        .HasColumnType("date");

                    b.Property<Guid>("UniqueID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("LokasiAngkutID");

                    b.HasIndex("ClientID");

                    b.HasIndex("KawasanID");

                    b.HasIndex("UniqueID")
                        .IsUnique();

                    b.ToTable("LokasiAngkut");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.TipeKendaraan", b =>
                {
                    b.Property<int>("TipeKendaraanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TipeKendaraanID"));

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("NamaTipe")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("TipeKendaraanID");

                    b.ToTable("TipeKendaraan");
                });

            modelBuilder.Entity("IzinAngkutKendaraan", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Transportation.IzinAngkut", null)
                        .WithMany()
                        .HasForeignKey("IzinAngkutsIzinAngkutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Transportation.Kendaraan", null)
                        .WithMany()
                        .HasForeignKey("KendaraansKendaraanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kabupaten", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Address.Provinsi", "Provinsi")
                        .WithMany("Kabupatens")
                        .HasForeignKey("ProvinsiID");

                    b.Navigation("Provinsi");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kecamatan", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Address.Kabupaten", "Kabupaten")
                        .WithMany("Kecamatans")
                        .HasForeignKey("KabupatenID");

                    b.Navigation("Kabupaten");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kelurahan", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Address.Kecamatan", "Kecamatan")
                        .WithMany("Kelurahans")
                        .HasForeignKey("KecamatanID");

                    b.Navigation("Kecamatan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.ClientPkm", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Common.Client", "Client")
                        .WithOne("ClientPkm")
                        .HasForeignKey("SharedLibrary.Entities.Common.ClientPkm", "ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Address.Kelurahan", "Kelurahan")
                        .WithMany("ClientPkms")
                        .HasForeignKey("KelurahanID");

                    b.Navigation("Client");

                    b.Navigation("Kelurahan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Timbangan.Transaction", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Transportation.Kendaraan", "Kendaraan")
                        .WithMany("Transactions")
                        .HasForeignKey("KendaraanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Common.Status", "Status")
                        .WithMany("Transactions")
                        .HasForeignKey("StatusID");

                    b.Navigation("Kendaraan");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.DokumenKendaraan", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Transportation.Kendaraan", "Kendaraan")
                        .WithOne("DokumenKendaraan")
                        .HasForeignKey("SharedLibrary.Entities.Transportation.DokumenKendaraan", "KendaraanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kendaraan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.IzinAngkut", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Common.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Common.LokasiBuang", "LokasiBuang")
                        .WithMany("IzinAngkuts")
                        .HasForeignKey("LokasiBuangID");

                    b.HasOne("SharedLibrary.Entities.Common.LokasiIzin", "LokasiIzin")
                        .WithMany("IzinAngkuts")
                        .HasForeignKey("LokasiIzinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("LokasiBuang");

                    b.Navigation("LokasiIzin");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.Kendaraan", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Common.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Common.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Transportation.TipeKendaraan", "TipeKendaraan")
                        .WithMany("Kendaraans")
                        .HasForeignKey("TipeKendaraanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Status");

                    b.Navigation("TipeKendaraan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.LokasiAngkut", b =>
                {
                    b.HasOne("SharedLibrary.Entities.Common.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedLibrary.Entities.Common.Client", "Kawasan")
                        .WithMany("LokasiAngkuts")
                        .HasForeignKey("KawasanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Kawasan");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kabupaten", b =>
                {
                    b.Navigation("Kecamatans");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kecamatan", b =>
                {
                    b.Navigation("Kelurahans");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Kelurahan", b =>
                {
                    b.Navigation("ClientPkms");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Address.Provinsi", b =>
                {
                    b.Navigation("Kabupatens");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.Client", b =>
                {
                    b.Navigation("ClientPkm");

                    b.Navigation("LokasiAngkuts");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.LokasiBuang", b =>
                {
                    b.Navigation("IzinAngkuts");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.LokasiIzin", b =>
                {
                    b.Navigation("IzinAngkuts");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Common.Status", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.Kendaraan", b =>
                {
                    b.Navigation("DokumenKendaraan");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("SharedLibrary.Entities.Transportation.TipeKendaraan", b =>
                {
                    b.Navigation("Kendaraans");
                });
#pragma warning restore 612, 618
        }
    }
}
