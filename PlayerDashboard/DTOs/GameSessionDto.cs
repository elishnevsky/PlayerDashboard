using PlayerDashboard.Shared;

namespace PlayerDashboard.DTOs;

public class GameSessionDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; }
    public GameMode GameMode { get; set; }
    public bool Won { get; set; }
    public int Score { get; set; }
}
