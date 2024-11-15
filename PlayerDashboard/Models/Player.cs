namespace PlayerDashboard.Models;

public class Player
{
    public int Id { get; set; }
    public string DisplayName { get; set; } = String.Empty;
    public int Level { get; set; }
    public string? AvatarUrl { get; set; }
    public DateOnly AccountCreatedDate { get; set; }
    public string EmailAddress { get; set; } = String.Empty;
    public DateOnly DateOfBirth { get; set; }

    // Stats should be updated at the end of each game sessions to avoid expensive calculations
    public int TotalPlaytimeMinutes { get; set; }
    public int AverageGameTimeMinutes { get; set; }
    public int TotalGames { get; set; }
    public int TotalWins { get; set; }

    // Collection of game sessions played by the player
    public List<GameSession> GameSessions { get; set; } = new();
}
