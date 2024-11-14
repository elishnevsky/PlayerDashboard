using PlayerDashboard.DTOs;

namespace PlayerDashboard.Data
{
    public interface IPlayerRepository
    {
        List<GameSessionDto> GetGameSessionsByPlayerId(int id);
        PlayerDto GetPlayerById(int id);
    }
}