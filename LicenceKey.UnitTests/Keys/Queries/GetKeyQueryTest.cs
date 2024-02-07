using LicenceKey.BaseTests;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using LicenceKey.Application.Common.Dto.Keys;
using Microsoft.AspNetCore.TestHost;

namespace LicenceKey.UnitTests.Keys.Queries
{
    public class GetKeyQueryTest : Base
    {
        private const string BaseUrl = "/key/details";
        private readonly HttpClient _client;

        public GetKeyQueryTest()
        {
            _client = new TestServer(GetHostBuilder()).CreateClient();

            IServiceProvider GetHostBuilder()
            {
                throw new NotImplementedException();
            }
        }

        [Fact]
        public async Task GetCarListQuery_Filters_ReturnCarList()
        {
            //Given (Arrange) - what is part of request
        
            //When (Act) - what we do with that data
            var response = await _client.GetAsync(BaseUrl);
        
            //Then (Assert) - what is response
            using var _ = new AssertionScope();
        
            response.StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
            
            var result = await response.Content.ReadFromJsonAsync<KeyDetailsDto>();
        }
    }
}