using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Entities.Transportation;

[Table("DokumenKendaraan")]
public class DokumenKendaraan
{
    public Guid DokumenKendaraanID { get; set; } = Guid.Empty;

    public Guid KendaraanID { get; set; }

    [MaxLength(4, ErrorMessage = "Maksimal 4 karakter")]
    public string? TahunPembuatan { get; set; }

    [Required(ErrorMessage = "Tanggal berlaku STNK wajib diisi")]
    public DateOnly TglSTNK { get; set; }

    [Required(ErrorMessage = "Tanggal berlaku KIR wajib diisi")]
    public DateOnly TglKIR { get; set; }

    public DateOnly TglUjiEmisi { get; set; }

    public string? DokumenSTNK { get; set; }

    public string? DokumenKIR { get; set; }

    public string? FotoKendaraan { get; set; }

    public string? BuktiUjiEmisi { get; set; }

#nullable disable

    public Kendaraan Kendaraan { get; set; }
}
