namespace PlayerDashboard.DTOs;

// This is just to simulate authenticated user.
// This class is provided to all component in the application through CascadingUserContext component (in Components/Shared)
public class UserDto
{
    public int PlayerId { get; set; }
}
