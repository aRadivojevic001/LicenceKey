using MongoDB.Entities;

namespace LicenceKey.Domain.Entities;

[Collection("Users")]
public class User : BaseEntity
{
    public User(string username, bool active, string password, string email, decimal balance, decimal moneySpend)
    {
        Username = username;
        Active = active;
        Password = password;
        Email = email;
        Balance = balance;
        MoneySpend = moneySpend;
    }

    public User()
    {
        
    }

    


    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string Email { get; set; }
    
    public decimal Balance { get;  set; }
    
    public decimal MoneySpend { get; set; }
    
    
}