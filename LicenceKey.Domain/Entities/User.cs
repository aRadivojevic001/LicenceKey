namespace LicenceKey.Domain.Entities;

public class User
{
    public User()
    {
        
    }

    public User(string requestUsername, string requestPassword, string requestEmail, decimal requestBalance, string requestStatus)
    {
        throw new NotImplementedException();
    }


    public int UserID { get; set; }
    
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string Email { get; set; }
    
    public decimal Balance { get; set; }
    
    public string Status { get; set; }
    
    //Lista licenci
}