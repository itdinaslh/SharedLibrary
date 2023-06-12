using SharedLibrary.Entities.Common;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class LokasiIzinService : ILokasiIzin
{
    private readonly DlhDbContext context;

    public LokasiIzinService(DlhDbContext context)
    {
        this.context = context;
    }

    public IQueryable<LokasiIzin> LokasiIzins => context.LokasiIzins;
}
