namespace LicenceKey.Application.Common.Dto.Users;

public record UpdateUserDto(string? UserId, string? Username, string? Email, bool? Active,decimal? balance, decimal? moneySpend)
{
    internal UpdateUserDto AddLoggedInUser(string userId)
    {
        return this with { UserId = userId };
    }
}
