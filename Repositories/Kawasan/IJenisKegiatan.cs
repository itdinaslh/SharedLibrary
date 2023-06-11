using SharedLibrary.Entities.Kawasan;

namespace SharedLibrary.Repositories.Kawasan;

public interface IJenisKegiatan
{
	IQueryable<JenisKegiatan> JenisKegiatans { get; }
}
