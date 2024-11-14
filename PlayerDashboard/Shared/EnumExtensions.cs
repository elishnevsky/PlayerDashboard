using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PlayerDashboard.Shared;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue)
    {
        var displayName = enumValue.GetType()
                                   .GetMember(enumValue.ToString())
                                   .FirstOrDefault()?
                                   .GetCustomAttribute<DisplayAttribute>()?
                                   .GetName();

        return displayName ?? enumValue.ToString();
    }
}
