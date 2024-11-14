using PlayerDashboard.DTOs;
using PlayerDashboard.Mappers;

namespace PlayerDashboard.Data;

public class PlayerRepository : IPlayerRepository
{
    public PlayerDto GetPlayerById(int id)
    {
        var playerDto = SampleData.Player.ToPlayerDto();
        return playerDto;
    }

    public List<GameSessionDto> GetGameSessionsByPlayerId(int id)
    {
        var list = SampleData.Player.GameSessions.Select(session =>
        {
            return session.ToGameSessionDto();
        });

        return list.ToList();
    }
}
