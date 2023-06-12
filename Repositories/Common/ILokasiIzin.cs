using SharedLibrary.Entities.Common;

namespace SharedLibrary.Repositories.Common;

public interface ILokasiIzin
{
    IQueryable<LokasiIzin> LokasiIzins { get; }
}
