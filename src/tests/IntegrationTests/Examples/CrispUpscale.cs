/*
order: 70
title: Crisp Upscale
slug: crisp-upscale
*/

namespace Recraft.IntegrationTests;

public partial class Tests
{
    //// Upscale an image using the Crisp Upscale algorithm, which enhances
    //// image resolution while preserving sharp details and clarity.

    [TestMethod]
    [Ignore("Requires a valid image file and paid API call")]
    public async Task Example_CrispUpscale()
    {
        using var client = GetAuthenticatedClient();

        // Create a placeholder 1x1 pixel PNG for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        ProcessImageResponse response = await client.Image.CrispUpscaleAsync(
            request: new ProcessImageRequest
            {
                Image = imageBytes,
                Imagename = "low-res.png",
                ResponseFormat = ResponseFormat.Url,
            });

        response.Should().NotBeNull();
        response.Image.Should().NotBeNull();
        response.Image.Url.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Image ID: {response.Image.ImageId}");
        Console.WriteLine($"Upscaled URL: {response.Image.Url}");
        Console.WriteLine($"Credits used: {response.Credits}");
    }
}
