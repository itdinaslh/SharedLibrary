using SharedLibrary.Entities.Address;

namespace SharedLibrary.Repositories.Common;

public interface IAddress
{
    IQueryable<Provinsi> Provinsis { get; }

    IQueryable<Kabupaten> Kabupatens { get; }

    IQueryable<Kecamatan> Kecamatans { get; }

    IQueryable<Kelurahan> Kelurahans { get; }
}
