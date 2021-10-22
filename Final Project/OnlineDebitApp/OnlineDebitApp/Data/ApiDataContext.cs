using Microsoft.EntityFrameworkCore;
using OnlineDebitApp.Models;

namespace OnlineDebitApp.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<ItemData> CreditCardDetails { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }
    }
}