using Microsoft.EntityFrameworkCore;
using SharedLibrary.Entities.Address;
using SharedLibrary.Entities.Common;
using SharedLibrary.Entities.Kawasan;
using SharedLibrary.Entities.Timbangan;
using SharedLibrary.Entities.Transportation;
using System;

namespace SharedLibrary;

public class DlhDbContext : DbContext
{
#nullable disable

    public DlhDbContext(DbContextOptions<DlhDbContext> options) : base(options) { }

    public DbSet<Status> Statuses { get; set; }
    public DbSet<Provinsi> Provinsis { get; set; }
    public DbSet<Kabupaten> Kabupatens { get; set; }
    public DbSet<Kecamatan> Kecamatans { get; set; }
    public DbSet<Kelurahan> Kelurahans { get; set; }
    public DbSet<TipeKendaraan> TipeKendaraans { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientPkm> ClientPkms { get; set; }
    public DbSet<LokasiIzin> LokasiIzins { get; set; }
    public DbSet<LokasiBuang> LokasiBuangs { get; set; }
    public DbSet<IzinAngkut> IzinAngkuts { get; set; }
    public DbSet<Kendaraan> Kendaraans { get; set; }
    public DbSet<DokumenKendaraan> DokumenKendaraans { get; set; }
    public DbSet<Transaction> Penimbangan { get; set; }
    public DbSet<JenisKegiatan> JenisKegiatans { get; set; }
    public DbSet<JenisIzinLingkungan> JenisIzinLingkungans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=admin; Password=Admin123$; Host=127.0.0.1; Port=5432; Database=LingkunganDB; Pooling=true;");
    }
}
