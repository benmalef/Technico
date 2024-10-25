using Microsoft.EntityFrameworkCore;
using Tecnico.Models;

namespace Tecnico;


public class AppDbContext : DbContext
{
  
    // Define DbSets for each entity you want to map to a database table
    public DbSet<Owner> Owners { get;set; }
    public DbSet<Item> Items { get; set; }

    public DbSet<Repair> Repairs { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        string connectionString = "Server=localhost;Database=Technico;Trusted_Connection=True; TrustServerCertificate=True;;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}

