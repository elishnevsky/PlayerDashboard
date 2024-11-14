using PlayerDashboard.DTOs;

namespace PlayerDashboard.Data
{
    public interface IPlayerRepository
    {
        Task<PlayerDto> GetPlayerByIdAsync(int id);
        Task<List<GameSessionDto>> GetGameSessionsByPlayerIdAsync(int id, int? take = null);
    }
}