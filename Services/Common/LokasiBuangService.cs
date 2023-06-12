using SharedLibrary.Entities.Common;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class LokasiBuangService : ILokasiBuang
{
    private readonly DlhDbContext context;

    public LokasiBuangService(DlhDbContext context)
    {
        this.context = context;
    }

    public IQueryable<LokasiBuang> LokasiBuangs => context.LokasiBuangs;
}
