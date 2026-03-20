/*
order: 60
title: Remove Background
slug: remove-background
*/

namespace Recraft.IntegrationTests;

public partial class Tests
{
    //// Remove the background from an image using the Recraft API.
    //// The result is an image with a transparent background, useful
    //// for product photos, portraits, and design assets.

    [TestMethod]
    [Ignore("Requires a valid image file and paid API call")]
    public async Task Example_RemoveBackground()
    {
        using var client = GetAuthenticatedClient();

        // Create a placeholder 1x1 pixel PNG for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        ProcessImageResponse response = await client.Image.RemoveBackgroundAsync(
            request: new ProcessImageRequest
            {
                Image = imageBytes,
                Imagename = "photo.png",
                ResponseFormat = ResponseFormat.Url,
            });

        response.Should().NotBeNull();
        response.Image.Should().NotBeNull();
        response.Image.Url.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Image ID: {response.Image.ImageId}");
        Console.WriteLine($"Result URL: {response.Image.Url}");
        Console.WriteLine($"Credits used: {response.Credits}");
    }
}
