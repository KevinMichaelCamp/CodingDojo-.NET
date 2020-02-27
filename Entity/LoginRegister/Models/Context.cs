using Microsoft.EntityFrameworkCore;

namespace LoginRegister.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}