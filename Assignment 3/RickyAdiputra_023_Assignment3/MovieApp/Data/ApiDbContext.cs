using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
//using MySQL.Data.EntityFrameworkCore.Extensions;
//using Microsoft.EntityFrameworkCore.Sqlite;

namespace MovieApp.Data
{
    public class ApiDbContext : DbContext{
        public virtual DbSet<ItemData> Items {get; set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }
    }
}