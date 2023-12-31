﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Entities.Common;

[Table("Notifications")]
public class Notification
{
    [Key]
    public Guid NotificationID { get; set; } = Guid.Empty;

    public int NotificationTypeID { get; set; }

    [MaxLength(150)]
    public string? UserID { get; set; }

#nullable disable

    [MaxLength(50)]
    public string Title { get; set; }

    [MaxLength(50)]
    public string SubTitle { get; set; }

    [MaxLength(100)]
    public string Content { get; set; }

    public bool IsAdminNotification { get; set; } = false;

    public bool IsRead { get; set; } = false;

    [DataType(DataType.Text)]
    public string Href { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public NotificationType NotificationType { get; set; }
}
