namespace PlayerDashboard.DTOs;

public class PlayerDto
{
    public int Id { get; set; }
    public string DisplayName { get; set; } = String.Empty;
    public int Level { get; set; }
    public DateOnly AccountCreatedDate { get; set; }
    public string EmailAddress { get; set; } = String.Empty;
    public DateOnly DateOfBirth { get; set; }
    public int TotalPlaytimeMinutes { get; set; }
    public int AverageGameTimeMinutes { get; set; }
    public int TotalGames { get; set; }
    public int TotalWins { get; set; }

    // Calculated properties
    public string WinRate => ((double)TotalWins / (double)TotalGames).ToString("0.##%");
}
