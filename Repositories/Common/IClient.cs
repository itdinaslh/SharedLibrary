using SharedLibrary.Entities.Common;

namespace SharedLibrary.Repositories.Common;

public interface IClient
{
	IQueryable<Client> Clients { get; }
	IQueryable<ClientPkm> ClientPkms { get; }
}
