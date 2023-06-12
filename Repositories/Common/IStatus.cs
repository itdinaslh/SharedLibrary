using SharedLibrary.Entities.Common;

namespace SharedLibrary.Repositories.Common;

public interface IStatus
{
    IQueryable<Status> Statuses { get; }

    Task SaveDataAsync(Status status);
}
