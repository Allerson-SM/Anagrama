using Anagrama.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Anagrama.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Anagramas> Anagrama { get; set; }
    }
}