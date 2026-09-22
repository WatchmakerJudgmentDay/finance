using Microsoft.EntityFrameworkCore;
using Finance.Models;
namespace Finance.Data
{
    public class CashContext : DbContext
    {
        public CashContext(DbContextOptions<CashContext> options) : base(options) { }
        public DbSet<Expense> Expenses => Set<Expense>();
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Expense>().Property(x => x.Amount).HasConversion<double>();
        }
    }
}
