/*
order: 50
title: Vectorize Image
slug: vectorize-image
*/

namespace Recraft.IntegrationTests;

public partial class Tests
{
    //// Convert a raster image to SVG vector format using the Recraft API.
    //// The vectorization process analyzes the image and produces a scalable
    //// vector graphic that can be resized without quality loss.

    [TestMethod]
    [Ignore("Requires a valid image file and paid API call")]
    public async Task Example_VectorizeImage()
    {
        using var client = GetAuthenticatedClient();

        // Create a placeholder 1x1 pixel PNG for demonstration
        var imageBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

        ProcessImageResponse response = await client.Image.VectorizeImageAsync(
            request: new VectorizeImageRequest(
                value1: new ProcessImageRequest
                {
                    Image = imageBytes,
                    Imagename = "input.png",
                    ResponseFormat = ResponseFormat.Url,
                },
                value2: null));

        response.Should().NotBeNull();
        response.Image.Should().NotBeNull();
        response.Image.Url.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Image ID: {response.Image.ImageId}");
        Console.WriteLine($"SVG URL: {response.Image.Url}");
        Console.WriteLine($"Credits used: {response.Credits}");
    }
}
