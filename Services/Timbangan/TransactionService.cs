
using SharedLibrary.Entities.Timbangan;
using SharedLibrary.Repositories.Timbangan;

namespace SharedLibrary.Services.Timbangan;

public class TransactionService : ITransaction
{
    private readonly DlhDbContext context;

    public TransactionService(DlhDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Transaction> Transactions => context.Penimbangan;

    public async Task AddDataAsync(Transaction trans)
    {
        await context.Penimbangan.AddAsync(trans);

        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Transaction trans)
    {
        Transaction? trx = await context.Penimbangan.FindAsync(trans.TransactionID);

        if (trx is not null)
        {
            trx.StatusID = 4;
            trx.UpdatedBy = trans.UpdatedBy;
            trx.UpdatedAt = DateTime.Now;

            context.Penimbangan.Update(trx);
        }

        await context.SaveChangesAsync();
    }
}
