namespace LicenceKey.Application.Common.Dto.Users;

public record UpdateUserDto(string? UserId, string? Name, string? Email, bool? Active)
{
    internal UpdateUserDto AddLoggedInUser(string userId)
    {
        return this with { UserId = userId };
    }
}
