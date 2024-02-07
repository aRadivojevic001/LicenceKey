

using LicenceKey.Domain.Entities;

namespace LicenceKey.BaseTests.Data;

public class KeyBuilder
{
    public Key Build()
    {
        return new Key()
        {
            Active = true,
            Name = "GTA V",
        };
    }
}