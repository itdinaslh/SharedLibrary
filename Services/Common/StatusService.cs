using SharedLibrary.Entities.Common;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class StatusService : IStatus
{
    private readonly DlhDbContext context;

    public StatusService(DlhDbContext context) => this.context = context;

    public IQueryable<Status> Statuses => context.Statuses;

    public async Task SaveDataAsync(Status status)
    {
        if (status.StatusID == 0)
        {
            await context.Statuses.AddAsync(status);
        }
        else
        {
            Status? data = await context.Statuses.FindAsync(status.StatusID);

            if (data is not null)
            {
                data.StatusName = status.StatusName;

                context.Statuses.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
