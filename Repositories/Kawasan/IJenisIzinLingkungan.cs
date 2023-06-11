using SharedLibrary.Entities.Kawasan;

namespace SharedLibrary.Repositories.Kawasan;

public interface IJenisIzinLingkungan
{
	IQueryable<JenisIzinLingkungan> JenisIzinLingkungans { get; }

	Task SaveDataAsync(JenisIzinLingkungan jenis);
}
