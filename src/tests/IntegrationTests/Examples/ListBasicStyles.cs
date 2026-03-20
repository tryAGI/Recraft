/*
order: 30
title: List Basic Styles
slug: list-basic-styles
*/

namespace Recraft.IntegrationTests;

public partial class Tests
{
    //// Retrieve the list of basic image styles available for generation.

    [TestMethod]
    public async Task Example_ListBasicStyles()
    {
        using var client = GetAuthenticatedClient();

        ListBasicStylesResponse response = await client.Style.ListBasicStylesAsync();

        response.Should().NotBeNull();
        response.Styles.Should().NotBeNullOrEmpty();

        foreach (var style in response.Styles)
        {
            Console.WriteLine($"Style: {style.Name} (ID: {style.Id})");
        }
    }
}
