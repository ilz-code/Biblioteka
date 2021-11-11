using Biblioteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Data
{
    public class BiblDbContext : DbContext
    {
        public BiblDbContext(DbContextOptions<BiblDbContext> options) : base(options)
        {
        }

        public DbSet<Gramata> Gramatas { get; set; }
        public DbSet<Autors> Autors { get; set; }
    }
}
