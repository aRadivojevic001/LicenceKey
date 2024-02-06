using MongoDB.Entities;

namespace LicenceKey.Domain.Entities;

[Collection("vendors")]
public class Vendor : BaseEntity
{
    
    [Field("name")]
    public string Name { get; set; }   
    
    [Field("year_production")]
    public int YearProduction { get; private set; }
    
    public Vendor(string name)
    {
        Name = name;
    }

    private Vendor()
    {
        
    }
}

