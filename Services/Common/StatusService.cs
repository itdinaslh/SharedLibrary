using SharedLibrary.Entities.Common;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class StatusService : IStatus
{
    private readonly DlhDbContext context;

    public StatusService(DlhDbContext context) => this.context = context;

    public IQueryable<Status> Statuses => context.Statuses;

}
