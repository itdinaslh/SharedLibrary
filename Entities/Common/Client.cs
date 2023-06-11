using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Entities.Common;

[Table("Clients")]
public class Client
{
    [Key]
    public Guid ClientID { get; set; } = Guid.Empty;

#nullable disable

    [MaxLength(150)]
    public string ClientName { get; set; }

    public bool IsVerified { get; set; } = false;

    public bool IsB2B { get; set; } = false;

#nullable enable

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    public ClientPkm? ClientPkm { get; set; }
}
