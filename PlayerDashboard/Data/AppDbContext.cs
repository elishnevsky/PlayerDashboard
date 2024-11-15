using Microsoft.EntityFrameworkCore;
using PlayerDashboard.Models;

namespace PlayerDashboard.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<Player> Players { get; set; }
    public required DbSet<GameSession> GameSessions { get; set; }

    // Seed the database
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().HasData(SampleData.Player);
        modelBuilder.Entity<GameSession>().HasData(SampleData.GameSessions);
    }
}
