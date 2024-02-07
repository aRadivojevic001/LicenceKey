namespace LicenceKey.Application.Common.Dto.Users;

public record CreateUserDto(string Username, bool Active, string Password, string Email, decimal Balance, decimal moneySpend);
