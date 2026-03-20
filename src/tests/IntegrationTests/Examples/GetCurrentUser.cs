/*
order: 40
title: Get Current User
slug: get-current-user
*/

namespace Recraft.IntegrationTests;

public partial class Tests
{
    //// Retrieve information about the currently authenticated user,
    //// including available credits and account details.

    [TestMethod]
    public async Task Example_GetCurrentUser()
    {
        using var client = GetAuthenticatedClient();

        User user = await client.User.GetCurrentUserAsync();

        user.Should().NotBeNull();
        user.Id.Should().NotBe(default(Guid));

        Console.WriteLine($"User ID: {user.Id}");
        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"Credits: {user.Credits}");
    }
}
