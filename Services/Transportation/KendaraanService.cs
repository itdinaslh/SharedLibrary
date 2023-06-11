using SharedLibrary.Entities.Transportation;
using SharedLibrary.Repositories.Transportation;

namespace SharedLibrary.Services.Transportation;

public class KendaraanService : IKendaraan
{
    private readonly DlhDbContext context;

    public KendaraanService(DlhDbContext context) => this.context = context;

    public IQueryable<TipeKendaraan> TipeKendaraans => context.TipeKendaraans;

    public IQueryable<Kendaraan> Kendaraans => context.Kendaraans;

    public Task SaveKendaraanAsync(Kendaraan kendaraan)
    {
        throw new NotImplementedException();
    }

    public async Task SaveTipeAsync(TipeKendaraan tipe)
    {
        if (tipe.TipeKendaraanID == 0)
        {
            await context.AddAsync(tipe);
        }
        else
        {
            var data = await context.TipeKendaraans.FindAsync(tipe.TipeKendaraanID);

            if (data is not null)
            {
                data.Kode = tipe.Kode;
                data.NamaTipe = tipe.NamaTipe;                

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
