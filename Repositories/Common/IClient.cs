using SharedLibrary.Entities.Common;
using SharedLibrary.Entities.Transportation;

namespace SharedLibrary.Repositories.Common;

public interface IClient
{
	IQueryable<Client> Clients { get; }
	IQueryable<ClientPkm> ClientPkms { get; }

	IQueryable<IzinAngkut> IzinAngkuts { get; }

	Task SaveClientAsync(Client client);

	Task SavePKMAsync(Client client);

	Task SaveIzinAngkut(IzinAngkut izin);

    Task AddKendaraanToIzinAngkut(Guid IzinAngkut, Kendaraan kendaraan);
}
