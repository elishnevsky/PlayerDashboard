using PlayerDashboard.DTOs;
using PlayerDashboard.Mappers;

namespace PlayerDashboard.Data;

public class PlayerRepository : IPlayerRepository
{
    private readonly ILogger<PlayerRepository> _logger;

    public PlayerRepository(ILogger<PlayerRepository> logger)
    {
        _logger = logger;
    }

    public async Task<PlayerDto> GetPlayerByIdAsync(int id)
    {
        _logger.LogInformation($"Getting player info for Player {id}");

        await Task.Delay(1000);

        var playerDto = SampleData.Player.ToPlayerDto();
        return playerDto;
    }

    public async Task<List<GameSessionDto>> GetGameSessionsByPlayerIdAsync(int id, int? take)
    {
        _logger.LogInformation($"Getting player's game sessions for Player {id}");

        await Task.Delay(2000);

        var list = take.HasValue ? SampleData.Player.GameSessions.Take(take.Value) : SampleData.Player.GameSessions;

        return list.Select(session => session.ToGameSessionDto()).ToList();
    }
}
