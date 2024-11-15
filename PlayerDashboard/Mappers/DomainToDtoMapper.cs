using PlayerDashboard.DTOs;
using PlayerDashboard.Models;

namespace PlayerDashboard.Mappers;

public static class DomainToDtoMapper
{
    // Extension method on Player class to map it to PlayerDto
    public static PlayerDto ToPlayerDto(this Player player)
    {
        return new PlayerDto
        {
            Id = player.Id,
            DisplayName = player.DisplayName,
            Level = player.Level,
            AccountCreatedDate = player.AccountCreatedDate,
            EmailAddress = player.EmailAddress,
            DateOfBirth = player.DateOfBirth,
            TotalPlaytimeMinutes = player.TotalPlaytimeMinutes,
            AverageGameTimeMinutes = player.AverageGameTimeMinutes,
            TotalGames = player.TotalGames,
            TotalWins = player.TotalWins
        };
    }

    // Extension method on GameSession class to map it to GameSessionDto
    public static GameSessionDto ToGameSessionDto(this GameSession gameSession)
    {
        return new GameSessionDto
        {
            Id = gameSession.Id,
            Date = gameSession.Date,
            Duration = gameSession.Duration,
            GameMode = gameSession.GameMode,
            Score = gameSession.Score,
            Won = gameSession.Won
        };
    }
}
