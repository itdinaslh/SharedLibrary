using SharedLibrary.Entities.Common;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class NotificationService : INotification
{
    private readonly DlhDbContext context;

    public NotificationService(DlhDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Notification> Notifications => context.Notifications;

    public async Task AddNotification(Notification notification)
    {
        await context.Notifications.AddAsync(notification);

        context.SaveChanges();
    }
}
