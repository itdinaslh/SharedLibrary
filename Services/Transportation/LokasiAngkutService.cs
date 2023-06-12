using SharedLibrary.Entities.Transportation;
using SharedLibrary.Repositories.Transportation;

namespace SharedLibrary.Services.Transportation;

public class LokasiAngkutService : ILokasiAngkut
{
    private readonly DlhDbContext context;

    public LokasiAngkutService(DlhDbContext context)
    {
        this.context = context;
    }

    public IQueryable<LokasiAngkut> LokasiAngkuts => context.LokasiAngkuts;
}
