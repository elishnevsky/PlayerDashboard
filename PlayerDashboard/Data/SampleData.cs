using PlayerDashboard.Models;
using PlayerDashboard.Shared;

namespace PlayerDashboard.Data;

// This class is used solely for generating random data to seed the database
public static class SampleData
{
    public static Player Player { get; }
    public static List<GameSession> GameSessions { get; } = new();

    private static readonly Random random = new Random();

    static SampleData()
    {
        var accountCreatedDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-3));

        // Create a new player
        var player = new Player
        {
            Id = 1,
            DisplayName = "ProGamer123",
            AccountCreatedDate = accountCreatedDate,
            Level = 120,
            AvatarUrl = "https://cdn.jsdelivr.net/gh/alohe/memojis/png/upstream_17.png",
            EmailAddress = "john.smith@microsoft.com",
            DateOfBirth = new DateOnly(2008, 8, 10),
        };

        // Create game sessions
        var sessions = new List<GameSession>();

        for (int i = 0; i < 90; i++)
        {
            sessions.Add(new GameSession
            {
                Id = i + 1,
                Date = new DateTime(accountCreatedDate.AddDays(i), GetRandomTime()),
                Duration = GetRandomDuration(),
                GameMode = GetRandomGameMode(),
                Score = GetRandomScore(),
                Won = GetRandomBoolean(),
                PlayerId = player.Id,
            });
        }

        player.TotalPlaytimeMinutes = sessions.Sum(s => s.Duration);
        player.TotalGames = sessions.Count;
        player.TotalWins = sessions.Count(s => s.Won);
        player.AverageGameTimeMinutes = player.TotalGames > 0 ? player.TotalPlaytimeMinutes / player.TotalGames : 0;

        Player = player;
        GameSessions = sessions;
    }

    private static TimeOnly GetRandomTime()
    {
        Random random = new Random();
        int startMinutes = 10 * 60; // 10:00 AM in minutes
        int endMinutes = 18 * 60;   // 6:00 PM in minutes

        // Generate a random number of minutes within the range
        int randomMinutes = random.Next(startMinutes, endMinutes);

        // Convert minutes back to TimeOnly
        return TimeOnly.FromTimeSpan(TimeSpan.FromMinutes(randomMinutes));
    }

    private static int GetRandomDuration()
    {
        int minDuration = 30;    // 30 minutes
        int maxDuration = 240;   // 4 hours in minutes

        // Generate and return a random duration in minutes within the range
        return random.Next(minDuration, maxDuration + 1);
    }

    private static GameMode GetRandomGameMode()
    {
        Array values = Enum.GetValues(typeof(GameMode));
        return (GameMode)values.GetValue(random.Next(values.Length))!;
    }

    private static int GetRandomScore()
    {
        int minScore = 10;  // Represents 1000 when multiplied by 100
        int maxScore = 40;  // Represents 4000 when multiplied by 100

        // Generate a random score within the range and multiply by 100 to end with "00"
        return random.Next(minScore, maxScore + 1) * 100;
    }

    private static bool GetRandomBoolean()
    {
        return random.Next(2) == 1;
    }
}
