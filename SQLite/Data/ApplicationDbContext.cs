using Microsoft.EntityFrameworkCore;
using SQLite.Models;

namespace SQLite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<RpgCharacter> RpgCharacters { get; set; } = default!;
    }
}
