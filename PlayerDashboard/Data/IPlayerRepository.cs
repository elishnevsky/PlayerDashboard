using PlayerDashboard.DTOs;

namespace PlayerDashboard.Data
{
    public interface IPlayerRepository
    {
        // Asynchronously retrieves a player's information by their unique ID
        Task<PlayerDto> GetPlayerByIdAsync(int id);

        // Asynchronously retrieves a list of game sessions for a specific player by their ID
        // Allows an optional limit on the number of sessions returned ('take' parameter)
        Task<List<GameSessionDto>> GetGameSessionsByPlayerIdAsync(int id, int? take = null);

        // Asynchronously updates basic player information
        Task UpdatePlayerProfileAsync(int id, PlayerFormModel model);
    }
}