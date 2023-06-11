using SharedLibrary.Entities.Common;
using SharedLibrary.Entities.Timbangan;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Entities.Transportation;

[Table("Kendaraan")]
public class Kendaraan
{
    [Key]
    public Guid KendaraanID { get; set; } = Guid.Empty;

    public Guid ClientID { get; set; }

#nullable disable
    [MaxLength(150)]
    public string AreaKerja { get; set; }

    [Required(ErrorMessage = "No Polisi wajib diisi")]
    [MaxLength(25, ErrorMessage = "Max 25 Karakter")]
    public string NoPolisi { get; set; }

    [Required(ErrorMessage = "No Pintu wajib diisi")]
    [MaxLength(25, ErrorMessage = "Max 25 karakter")]
    public string NoPintu { get; set; }    

    public int TipeKendaraanID { get; set; }

#nullable enable

    [MaxLength(40)]
    public string? RFID { get; set; }

    [MaxLength(4, ErrorMessage = "Maksimal 4 karakter")]
    public string? TahunPembuatan { get; set; }

    public int? BeratKIR { get; set; }

    public bool? IsPasar { get; set; } = false;

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

#nullable disable

    public TipeKendaraan TipeKendaraan { get; set; }

    public Client Client { get; set; }

#nullable enable
    public DokumenKendaraan? DokumenKendaraan { get; set; }

#nullable disable

    public List<Transaction> Transactions { get; set; }

    public List<IzinAngkut> IzinAngkuts { get; set; }
}
