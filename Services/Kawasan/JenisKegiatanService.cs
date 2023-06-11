

using SharedLibrary.Entities.Kawasan;
using SharedLibrary.Repositories.Kawasan;

namespace SharedLibrary.Services.Kawasan;

public class JenisKegiatanService : IJenisKegiatan
{
	private readonly DlhDbContext context;

	public JenisKegiatanService(DlhDbContext context) => this.context = context;

	public IQueryable<JenisKegiatan> JenisKegiatans => context.JenisKegiatans;
}
