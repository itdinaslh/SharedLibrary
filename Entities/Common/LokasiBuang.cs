using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SharedLibrary.Entities.Transportation;

namespace SharedLibrary.Entities.Common;

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
