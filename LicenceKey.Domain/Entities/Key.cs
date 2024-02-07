using MongoDB.Entities;

namespace LicenceKey.Domain.Entities;

[Collection("Keys")]
public class Key : BaseEntity
{
    
    // public Key(string name, bool active ,string keyType, decimal price, string status, string category)
    // {
    //     Name = name;
    //     Active = active;
    //     KeyType = keyType;
    //     Price = price;
    //     Status = status;
    //     Category = category;
    //     this.InitOneToMany(() => Users);
    // }

    public Key()
    {
        this.InitOneToMany(() => Users);
    }
    public Key AddVendor(One<Vendor> vendor)
    {
        Vendor = vendor;

        return this;
    }
    
    public Key AddUser(Many<User> users)
    {
        Users = users;

        return this;
    }
    

    [Field("name")]
    public string Name { get;  set; }
    
    [Field("keyType")]
    public string KeyType { get; set; }

    [Field("price")]
    public decimal Price { get;  set; }
    
    [Field("status")]
    public string Status { get;  set; } // Dostupan, rezervisan, prodat
    
    [Field("category")]
    public string Category { get; set; }
    
    [Field("vendorId")]
    public One<Vendor> Vendor { get; set; }// ID prodavca koji je postavio ključ
    
    [Field("Users")]
    public Many<User> Users { get; set; }// ID korisnika koji je postavio ključ

}