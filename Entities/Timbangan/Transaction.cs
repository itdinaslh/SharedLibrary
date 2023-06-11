using SharedLibrary.Entities.Common;
using SharedLibrary.Entities.Transportation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Entities.Timbangan;

[Table("Pemimbangan")]
public class Transaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long TransactionID { get; set; }

    public Guid TransactionGUID { get; set; } = Guid.NewGuid();

#nullable disable    

    public Guid KendaraanID { get; set; }

    [MaxLength(20)]
    public string NoPolisi { get; set; }

    [MaxLength(30)]
    public string NoPintu { get; set; }

    public int BeratMasuk { get; set; }

    public DateOnly TglMasuk { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public TimeOnly JamMasuk { get; set; } = TimeOnly.FromDateTime(DateTime.Now);

    public DateTime InDateTime { get; set; } = DateTime.Now;

#nullable enable

    public int? StatusID { get; set; }

    public bool? IsPasar { get; set; } = false;

    [MaxLength(15)]
    public string? RFID { get; set; }

    public int? BeratKeluar { get; set; }

    [MaxLength(75)]
    public string? Penugasan { get; set; }

    [MaxLength(50)]
    public string? AreaKerja { get; set; }

    public DateOnly? TglKeluar { get; set; }

    public TimeOnly? JamKeluar { get; set; }

    public DateTime? OutDateTime { get; set; }

    [MaxLength(75)]
    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Status? Status { get; set; }

#nullable disable

    public Kendaraan Kendaraan { get; set; }
}
