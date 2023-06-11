using SharedLibrary.Entities.Common;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class ClientService : IClient
{
	private readonly DlhDbContext context;

	public ClientService(DlhDbContext context) => this.context = context;

	public IQueryable<Client> Clients => context.Clients;

	public IQueryable<ClientPkm> ClientPkms => context.ClientPkms;


}
