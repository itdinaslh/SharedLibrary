using SharedLibrary.Entities.Transportation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Entities.Common;

[Table("LokasiIzin")]
public class LokasiIzin
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LokasiIzinID { get; set; }

#nullable disable
    [MaxLength(50)]
    public string NamaLokasi { get; set; }

    public List<IzinAngkut> IzinAngkuts { get; set; }

    //public List<IzinOlah> IzinOlahs { get; set; }

    //public List<IzinKegiatan> Kawasans { get; set; }
}
