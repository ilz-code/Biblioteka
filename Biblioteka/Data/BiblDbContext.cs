using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
