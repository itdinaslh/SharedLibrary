using SharedLibrary.Entities.Timbangan;

namespace SharedLibrary.Repositories.Timbangan;

public interface ITransaction
{
    IQueryable<Transaction> Transactions { get; }

    Task AddDataAsync(Transaction trans);

    Task UpdateAsync(Transaction trans);
}
