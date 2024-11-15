using Microsoft.EntityFrameworkCore;
using PlayerDashboard.DTOs;
using PlayerDashboard.Mappers;

namespace PlayerDashboard.Data;

public class PlayerRepository : IPlayerRepository
{
    private readonly ILogger<PlayerRepository> _logger;
    private readonly AppDbContext _appDbContext;

    public PlayerRepository(ILogger<PlayerRepository> logger, AppDbContext appDbContext)
    {
        _logger = logger;
        _appDbContext = appDbContext;
    }

    // Asynchronously retrieves a player's information by their ID
    public async Task<PlayerDto> GetPlayerByIdAsync(int id)
    {
        _logger.LogInformation($"Getting player info for Player {id}");

        // Simulates latency in fetching data
        await Task.Delay(150);

        // Attempts to find the player with the specified ID in the database
        var player = await _appDbContext.Players.FindAsync(id);

        // Checks if the player was not found in the database
        if (player == null)
        {
            // Throws a general exception if player not found;
            // Consider using a custom exception (e.g., PlayerNotFoundException) for better error handling
            throw new ApplicationException($"Player with ID {id} not found");
        }

        // Converts the retrieved player entity to a PlayerDto object for returning
        return player.ToPlayerDto();
    }


    // Asynchronously retrieves a list of game sessions for a specific player by their ID
    // Optionally limits the number of sessions returned if 'take' parameter is provided
    public async Task<List<GameSessionDto>> GetGameSessionsByPlayerIdAsync(int id, int? take)
    {
        _logger.LogInformation($"Getting player's game sessions for Player {id}");

        // Simulates latency in fetching data
        await Task.Delay(250);

        // Prepares a query to fetch game sessions for the specified player ID, without tracking changes
        var sessionsQuery = _appDbContext.GameSessions
                                         .AsNoTracking()
                                         .OrderByDescending(session => session.Date)
                                         .Where(session => session.PlayerId == id);

        // Applies a limit on the number of sessions if 'take' parameter has a value
        if (take.HasValue)
        {
            sessionsQuery = sessionsQuery.Take(take.Value);
        }

        // Executes the query and converts each game session entity to a GameSessionDto for returning
        return await sessionsQuery.Select(session => session.ToGameSessionDto()).ToListAsync();
    }

    public async Task UpdatePlayerProfileAsync(int id, PlayerFormModel model)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var player = await _appDbContext.Players.FindAsync(id);

        // Checks if the player was not found in the database
        if (player == null)
        {
            // Throws a general exception if player not found;
            // Consider using a custom exception (e.g., PlayerNotFoundException) for better error handling
            throw new ApplicationException($"Player with ID {id} not found");
        }

        // Update fields
        player.DisplayName = model.DisplayName;
        player.EmailAddress = model.EmailAddress;
        player.AvatarUrl = model.AvatarUrl;
        player.DateOfBirth = model.DateOfBirth;

        // Save the player
        await _appDbContext.SaveChangesAsync();
    }
}
