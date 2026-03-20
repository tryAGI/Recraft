# Vectorize Image



This example assumes `using Recraft;` is in scope and `apiKey` contains your Recraft API key.

```csharp
using var client = new RecraftClient(apiKey);

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

Console.WriteLine($"Image ID: {response.Image.ImageId}");
Console.WriteLine($"SVG URL: {response.Image.Url}");
Console.WriteLine($"Credits used: {response.Credits}");
```