using SharedLibrary.Entities.Address;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Entities.Common;

[Table("ClientPkm")]
public class ClientPkm
{
    public Guid ClientPkmID { get; set; } = Guid.Empty;

    public Guid ClientID { get; set; }

#nullable disable

    [MaxLength(150)]
    public string UserEmail { get; set; }

    [MaxLength(15)]    
    public string Telp { get; set; }

#nullable enable

    [MaxLength(15)]
    public string? Fax { get; set; }

#nullable disable
    [MaxLength(15)]    
    public string KelurahanID { get; set; }

    [MaxLength(150)]    
    public string Alamat { get; set; }

#nullable enable
    [MaxLength(50)]
    public string? Latitude { get; set; }

    [MaxLength(50)]
    public string? Longitude { get; set; }

#nullable disable

    [MaxLength(75)]
    [Required(ErrorMessage = "Penanggung jawab wajib diisi")]
    public string PenanggungJawab { get; set; }

    [Required(ErrorMessage = "NIK / No KTP Penanggung Jawab wajib diisi")]
    [Display(Name = "NIK / No KTP")]
    [Range(0, 9999999999999999, ErrorMessage = "Masukan format NIK dengan benar")]
    [StringLength(16, MinimumLength = 16, ErrorMessage = "NIK harus 16 karakter")]
    [MaxLength(16)]
    public string NIK { get; set; }

    [Required(ErrorMessage = "No. NPWP Penanggung Jawab wajib diisi")]
    [MaxLength(30)]
    public string NPWP { get; set; }

    [MaxLength(75)]
    [Required(ErrorMessage = "Nama PIC wajib diisi")]
    public string PIC { get; set; }

    [MaxLength(15)]
    [Required(ErrorMessage = "No. HP PIC wajib diisi")]
    public string NoHpPIC { get; set; }

    [MaxLength(255)]
    public string DokumenKTP { get; set; }

    [MaxLength(255)]
    public string DokumenNPWP { get; set; }

    public bool IsAngkut { get; set; } = false;

    public bool IsOlah { get; set; } = false;

    public bool IsUsaha { get; set; } = false;

#nullable enable

    [MaxLength(150)]
    public string? NIB { get; set; }

    [MaxLength(255)]
    public string? DokumenNIB { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

#nullable disable

    public Kelurahan Kelurahan { get; set; }

    public Client Client { get; set; }
}
