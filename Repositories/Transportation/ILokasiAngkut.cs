
using SharedLibrary.Entities.Transportation;

namespace SharedLibrary.Repositories.Transportation;

public interface ILokasiAngkut
{
    IQueryable<LokasiAngkut> LokasiAngkuts { get; }
}
