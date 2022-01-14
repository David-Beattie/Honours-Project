using Microsoft.EntityFrameworkCore;

namespace honsProject.Shared
{
    public class dbContext : DbContext
    {
        public DbSet<Player> Players {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string CurrentDir = System.Environment.CurrentDirectory;
            string ParentDir = System.IO.Directory.GetParent(CurrentDir).FullName;
            string path = System.IO.Path.Combine(ParentDir, "players.db");
            optionsBuilder.UseSqlite($"Filename={path}");


        }
        
    }
}