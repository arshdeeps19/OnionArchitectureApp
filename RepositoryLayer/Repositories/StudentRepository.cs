using System.Data.Entity;
using DomainLayer.Entities;

namespace RepositoryLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}
