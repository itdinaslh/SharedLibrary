using SharedLibrary.Entities.Transportation;
using SharedLibrary.Repositories.Transportation;
using System;

namespace SharedLibrary.Services.Transportation;

public class IzinAngkutService : IIzinAngkut
{
    private readonly DlhDbContext context;

    public IzinAngkutService(DlhDbContext ctx) => context = ctx;

    public IQueryable<IzinAngkut> IzinAngkuts => context.IzinAngkuts;

    public async Task AddKendaraan(Guid Izin, Kendaraan kendaraan)
    {
        var data = await context.IzinAngkuts.FindAsync(Izin);

        if (data != null)
        {
            data.Kendaraans = new List<Kendaraan>
            {
                kendaraan
            };
        }

        await context.SaveChangesAsync();
    }
}
