
using LicenceKey.Domain.Entities;

namespace LicenceKey.BaseTests.Data;

public class UserBuilder
{
    public User Build()
    {
        return new User()
        {
            Active = true,
            Username = "Marko",
            Password = "marko123",
            Email = "marko@gmail.com",
            Balance = 50,
            MoneySpend = 20
        };
    }
}