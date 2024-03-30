using System.IO;
using Godot;
using Microsoft.EntityFrameworkCore;

public class GameContext : DbContext
{
    public DbSet<Player> Players { get; set; }

    public GameContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var path = Path.Join(OS.GetUserDataDir(), "data.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
    }
}