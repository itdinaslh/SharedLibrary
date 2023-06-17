using Microsoft.EntityFrameworkCore;
using SharedLibrary.Entities.Transportation;
using SharedLibrary.Repositories.Transportation;

namespace SharedLibrary.Services.Transportation;

public class KendaraanService : IKendaraan
{
    private readonly DlhDbContext context;

    public KendaraanService(DlhDbContext context) => this.context = context;

    public IQueryable<TipeKendaraan> TipeKendaraans => context.TipeKendaraans;

    public IQueryable<Kendaraan> Kendaraans => context.Kendaraans;

    public async Task SaveKendaraanAsync(Kendaraan kendaraan)
    {
        if (kendaraan.KendaraanID == Guid.Empty)
        {
            await context.AddAsync(kendaraan);
        }
        else
        {
            var data = await context.Kendaraans.Include(x => x.DokumenKendaraan).FirstOrDefaultAsync(x => x.KendaraanID == kendaraan.KendaraanID);

            if (data is not null)
            {
                data.TipeKendaraanID = kendaraan.TipeKendaraanID;
                data.NoPolisi = kendaraan.NoPolisi;
                data.NoPintu = kendaraan.NoPintu;
                data.RFID = kendaraan.RFID;
                data.BeratKIR = kendaraan.BeratKIR;
                data.DokumenKendaraan!.TglSTNK = kendaraan.DokumenKendaraan!.TglSTNK;
                data.DokumenKendaraan!.TglKIR = kendaraan.DokumenKendaraan!.TglKIR;
                data.DokumenKendaraan!.TahunPembuatan = kendaraan.DokumenKendaraan!.TahunPembuatan;
                data.StatusID = kendaraan.StatusID;
                data.IsVerified = kendaraan.IsVerified;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
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
