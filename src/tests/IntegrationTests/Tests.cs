namespace Recraft.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RecraftClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RECRAFT_API_KEY") ??
            throw new AssertInconclusiveException("RECRAFT_API_KEY environment variable is not found.");

        var client = new RecraftClient(apiKey);
        
        return client;
    }
}
