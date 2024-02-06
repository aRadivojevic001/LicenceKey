using MongoDB.Entities;

namespace LicenceKey.Domain.Entities;

[Collection("Keys")]
public class Key : BaseEntity
{
    
    public Key(string name)
    {
        Name = name;
    }

    private Key()
    {
        
    }
    

    [Field("name")]
    public string Name { get; private set; }
    
    [Field("keyType")]
    public string KeyType { get; private set; }

    [Field("price")]
    public decimal Price { get; private set; }
    
    [Field("status")]
    public string Status { get; private set; } // Dostupan, rezervisan, prodat

    [Field("additionalInfo")]
    public string AdditionalInfo { get; private set; } // Informacije o ključu (samo vidljive nakon kupovine)
   
    [Field("category")]
    public string Category { get; private set; }
    
    [Field("vendorId")]
    public string VendorId { get; private set; } // ID prodavca koji je postavio ključ
    
    //Nisam dodao
    // [Field("dateAdded")]
    // public DateTime DateAdded { get; set; } 
    // [Field("expiryDate")]
    // public DateTime ExpiryDate { get; set; }
    // [Field("manufacturer")]
    // public string Manufacturer { get; set; }
}