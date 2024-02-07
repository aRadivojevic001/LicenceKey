using MongoDB.Entities;

namespace LicenceKey.Domain.Entities;

[Collection("Vendors")]
public class Vendor : BaseEntity
{
    
    [Field("name")]
    public string Name { get; set; }   
    
    public Vendor(string name, bool active)
    {
        Name = name;
        Active = active;
    }

    public Vendor()
    {
        
    }
}

