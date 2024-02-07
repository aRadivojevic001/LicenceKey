using LicenceKey.Domain.Entities;
using MediatR;
using MongoDB.Entities;

namespace LicenceKey.Application.Key.Commands;

public record CreateKeyCommand(string Name, bool Active, string VendorId, string KeyType, decimal Price, string Status, string Category, List<string> UserIds) : IRequest;

public class CreateKeyHandler : IRequestHandler<CreateKeyCommand>
{
    public async Task Handle(CreateKeyCommand request, CancellationToken cancellationToken)
    {
        
       //trazenje vendora u bazi i upis u kljuc 
       var vendor = await DB.Find<Domain.Entities.Vendor>().OneAsync(request.VendorId, cancellationToken);
        
       if (vendor == null)
       {
           throw new Exception("Vendor not found");
       }
       
       var users = new List<Domain.Entities.User>();
       
       foreach (var item in request.UserIds)
       {
           var user = await DB.Find<Domain.Entities.User>().OneAsync(item, cancellationToken);
           
           if (user == null)
           {
               throw new Exception("User not found");
           }
           users.Add(user);
       }

       var data = new Domain.Entities.Key
       {
           Name = request.Name,
           Active = request.Active,
           KeyType = request.KeyType,
           Price = request.Price,
           Status = request.Status,
           Category = request.Category,
           Vendor = new One<Domain.Entities.Vendor>(vendor)
       };
       await data.SaveAsync(cancellation: cancellationToken);
       await data.Users.AddAsync(users, cancellation: cancellationToken);
       // var data = new Domain.Entities.Key(request.Name, request.Active, request.KeyType, request.Price, request.Status,
       //         request.Category)
       //     .AddVendor(new One<Domain.Entities.Vendor>(vendor));
       //
       // await data.SaveAsync(cancellation: cancellationToken);
       //
       // await data.Users.AddAsync(users, cancellation: cancellationToken);

    }
}