using SharedLibrary.Entities.Common;
using SharedLibrary.Entities.Transportation;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class ClientService : IClient
{
	private readonly DlhDbContext context;

	public ClientService(DlhDbContext context) => this.context = context;

	public IQueryable<Client> Clients => context.Clients;

	public IQueryable<ClientPkm> ClientPkms => context.ClientPkms;

    public IQueryable<IzinAngkut> IzinAngkuts => context.IzinAngkuts;

    public Task AddKendaraanToIzinAngkut(Guid IzinAngkut, Kendaraan kendaraan)
    {
        throw new NotImplementedException();
    }

    public async Task SaveClientAsync(Client client)
    {
        if (client.ClientID == Guid.Empty)
        {
            if (!client.IsB2B)
            {
                client.ClientID = Guid.NewGuid();
                client.IsVerified = true;
            }
            
        }

        await context.AddAsync(client);

        await context.SaveChangesAsync();
    }

    public async Task SaveIzinAngkut(IzinAngkut detail)
    {
        if (detail.IzinAngkutID == Guid.Empty)
        {
            await context.AddAsync(detail);
        }
        else
        {
            IzinAngkut? data = await context.IzinAngkuts.FindAsync(detail.IzinAngkutID);

            if (data is not null)
            {
                data.JmlAngkutan = detail.JmlAngkutan;
                data.NoIzinUsaha = detail.NoIzinUsaha;
                data.TglTerbitIzin = detail.TglTerbitIzin;
                data.TglAkhirIzin = detail.TglAkhirIzin;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }

    public Task SavePKMAsync(Client client)
    {
        throw new NotImplementedException();
    }
}
