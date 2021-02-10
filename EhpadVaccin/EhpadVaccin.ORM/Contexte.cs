using Microsoft.EntityFrameworkCore;
namespace EhpadVaccin.ORM
{
    public class Contexte : DbContext
    {
        public int Id { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Injection> Injections { get; set; }
        public DbSet<Vaccin> Vaccins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=ehpad.db");
        }
       
    }
}
