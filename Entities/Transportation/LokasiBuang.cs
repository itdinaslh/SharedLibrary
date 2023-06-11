using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Entities.Transportation;

[Table("LokasiBuang")]
public class LokasiBuang
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LokasiBuangID { get; set; }

#nullable disable

    [MaxLength(50)]
    public string NamaLokasi { get; set; }

    public List<IzinAngkut> IzinAngkuts { get; set; }

    //public List<DetaillSpj> DetaillSpjs { get; set; }
}
