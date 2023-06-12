using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Entities.Common;

[Table("NotificationType")]
public class NotificationType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NotificationTypeID { get; set; }

#nullable disable

    [Required]
    [MaxLength(50)]
    public string NotificationName { get; set; }

    public List<Notification> Notifications { get; set; }

}
