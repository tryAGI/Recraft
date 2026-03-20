/*
order: 20
title: Generate Image
slug: generate-image
*/

namespace Recraft.IntegrationTests;

public partial class Tests
{
    //// Generate an image from a text prompt using the Recraft API.

    [TestMethod]
    public async Task Example_GenerateImage()
    {
        using var client = GetAuthenticatedClient();

        GenerateImageResponse response = await client.Image.GenerateImageAsync(
            request: new GenerateImageRequest
            {
                Prompt = "A serene mountain landscape at sunset",
                Size = ImageSize.x1024x1024,
            });

        response.Should().NotBeNull();
        response.Data.Should().NotBeNullOrEmpty();

        foreach (var image in response.Data ?? [])
        {
            Console.WriteLine($"Image URL: {image.Url}");
        }
    }
}
