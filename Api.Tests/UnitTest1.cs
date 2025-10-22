using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public UnitTest1(WebApplicationFactory<Program> factory) => _factory = factory;

    [Fact]
    public async Task Root_Returns_200()
    {
        var client = _factory.CreateClient();
        var resp = await client.GetAsync("/");
        Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
    }
}
