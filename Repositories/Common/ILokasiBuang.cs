using SharedLibrary.Entities.Common;

namespace SharedLibrary.Repositories.Common;

public interface ILokasiBuang
{
    IQueryable<LokasiBuang> LokasiBuangs { get; }
}
