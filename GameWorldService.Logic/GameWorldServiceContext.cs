using GameWorldService.Logic.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameWorldService.Logic
{
    public class GameWorldServiceContext : DbContext
    {
        public DbSet<GameFieldEntity> GameFields { get; set; }

        public GameWorldServiceContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=gameworldservicedb;Trusted_Connection=True;");
        }
    }
}
