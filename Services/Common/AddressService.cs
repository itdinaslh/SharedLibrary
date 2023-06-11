using SharedLibrary.Entities.Address;
using SharedLibrary.Repositories.Common;

namespace SharedLibrary.Services.Common;

public class AddressService : IAddress
{
	private readonly DlhDbContext context;

	public AddressService(DlhDbContext context) => this.context = context;

	public IQueryable<Provinsi> Provinsis => context.Provinsis;

	public IQueryable<Kabupaten> Kabupatens => context.Kabupatens;

	public IQueryable<Kecamatan> Kecamatans => context.Kecamatans;

	public IQueryable<Kelurahan> Kelurahans => context.Kelurahans;
}
