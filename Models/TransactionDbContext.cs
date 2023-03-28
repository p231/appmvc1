using Microsoft.EntityFrameworkCore;

namespace app.Models;

public class TransactionDbContext : DbContext
{
    public DbSet<Transaction> Transactions => Set<Transaction>();

    public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
    {

    }

}