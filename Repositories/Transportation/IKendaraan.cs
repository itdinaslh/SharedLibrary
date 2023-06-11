using SharedLibrary.Entities.Transportation;

namespace SharedLibrary.Repositories.Transportation;

public interface IKendaraan
{
    IQueryable<TipeKendaraan> TipeKendaraans {  get; }
    IQueryable<Kendaraan> Kendaraans { get; }

    Task SaveTipeAsync(TipeKendaraan tipe);

    Task SaveKendaraanAsync(Kendaraan kendaraan);
}
