namespace LicenceKey.Application.Common.Dto.Keys;

public record KeyDetailsDto(string Name, string VendorName, List<string> Users, string KeyType, decimal Price, string Status, string Category);
