using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Entities.Kawasan;

[Table("JenisKegiatan")]
public class JenisKegiatan
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JenisKegiatanID { get; set; }

#nullable disable
    [Required(ErrorMessage = "Prefix wajib diisi...")]
    [MaxLength(5, ErrorMessage = "Max 5 karakter!")]
    public string Prefix { get; set; }

    [Required(ErrorMessage = "Nama Kegiatan Wajib Diisi!")]
    [MaxLength(50, ErrorMessage = "Max 50 karakter")]
    public string NamaKegiatan { get; set; }

    public bool? IsActive { get; set; } = true;

    //public List<IzinKegiatan> Kawasans { get; set; }
}
