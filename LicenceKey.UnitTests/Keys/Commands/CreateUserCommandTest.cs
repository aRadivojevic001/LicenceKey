// using AutoMapper;
// using LicenceKey.Application.Common.Dto.Users;
// using LicenceKey.Application.User.Commands;
// using Moq;
//
// namespace LicenceKey.UnitTests.Keys.Commands
// {
//     [TestFixture]
//     public class CreateUserHandlerTests
//     {
//         private CreateUserHandler _handler;
//         private Mock<IMapper> _mapperMock;
//
//         [SetUp]
//         public void SetUp()
//         {
//             _mapperMock = new Mock<IMapper>();
//             _handler = new CreateUserHandler(_mapperMock.Object);
//         }
//
//         [Test]
//         public async Task Handle_ValidRequest_CreatesUser()
//         {
//             // Arrange
//             var createUserDto = new CreateUserDto { /* Set properties as needed */ };
//             var createUserCommand = new CreateUserCommand(createUserDto);
//             var cancellationToken = new CancellationToken();
//
//             var mappedUser = new Domain.Entities.User(); // Assuming this is a valid mapped user object
//
//             _mapperMock.Setup(x => x.Map<Domain.Entities.User>(createUserDto)).Returns(mappedUser);
//
//             // Act
//             await _handler.Handle(createUserCommand, cancellationToken);
//
//             // Assert
//             // You may add assertions here to verify if the user is created successfully
//             // For example, you can query the database to check if the user exists
//         }
//     }
// }