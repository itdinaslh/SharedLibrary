using SharedLibrary.Entities.Transportation;

namespace SharedLibrary.Repositories.Transportation;

public interface IIzinAngkut
{
    IQueryable<IzinAngkut> IzinAngkuts { get; }

    Task AddKendaraan(Guid IzinAngkut, Kendaraan kendaraan);
}