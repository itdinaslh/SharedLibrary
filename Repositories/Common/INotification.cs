using SharedLibrary.Entities.Common;

namespace SharedLibrary.Repositories.Common;

public interface INotification
{
    IQueryable<Notification> Notifications { get; }

    Task AddNotification(Notification notification);
}
