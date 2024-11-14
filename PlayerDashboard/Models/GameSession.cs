using PlayerDashboard.Shared;

namespace PlayerDashboard.Models;

public class GameSession
{
    public int Id { get; set; }
    public DateTime Date { get; set; }      // When the game started
    public TimeSpan Duration { get; set; }  // How long the game lasted
    public GameMode GameMode { get; set; }  // Mode of the game played
    public bool Won { get; set; }           // Whether the game was won
    public int Score { get; set; }          // Score achieved in the session

    // Reference to the player
    public int PlayerId { get; set; }
    public Player Player { get; set; } = default!;
}