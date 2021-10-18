using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore.Extensions;
//using Microsoft.EntityFrameworkCore.Sqlite;

namespace MovieApp.Data
{
    public class ApiDbContext : IdentityDbContext{
        public virtual DbSet<ItemData> Items {get; set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }
    }
}