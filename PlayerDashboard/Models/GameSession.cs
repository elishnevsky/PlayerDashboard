using PlayerDashboard.Shared;

namespace PlayerDashboard.Models;

public class GameSession
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; }
    public GameMode GameMode { get; set; }
    public bool Won { get; set; }
    public int Score { get; set; }

    // Reference to the player
    public int PlayerId { get; set; }
    public Player Player { get; set; } = default!;
}