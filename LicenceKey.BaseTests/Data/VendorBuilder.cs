using LicenceKey.Domain.Entities;



namespace LicenceKey.BaseTests.Data;

public class VendorBuilder
{
    public Vendor Build()
    {
        return new Vendor()
        {
            Active = true,
            Name = "Rockstar",
        };
    }
}