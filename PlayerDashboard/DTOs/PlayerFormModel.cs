namespace PlayerDashboard.DTOs;

// Model for editing basic player information
public class PlayerFormModel
{
    public string DisplayName { get; set; } = String.Empty;
    public string AvatarUrl { get; set; } = String.Empty;
    public string EmailAddress { get; set; } = String.Empty;
    public DateOnly DateOfBirth { get; set; }
}
