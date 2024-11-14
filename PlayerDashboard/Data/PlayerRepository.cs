using PlayerDashboard.DTOs;
using PlayerDashboard.Mappers;

namespace PlayerDashboard.Data;

public class PlayerRepository : IPlayerRepository
{
    public async Task<PlayerDto> GetPlayerByIdAsync(int id)
    {
        await Task.Delay(250);

        var playerDto = SampleData.Player.ToPlayerDto();
        return playerDto;
    }

    public async Task<List<GameSessionDto>> GetGameSessionsByPlayerIdAsync(int id, int? take)
    {
        await Task.Delay(500);

        var list = take.HasValue ? SampleData.Player.GameSessions.Take(take.Value) : SampleData.Player.GameSessions;

        return list.Select(session => session.ToGameSessionDto()).ToList();
    }
}
