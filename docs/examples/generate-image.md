# Generate Image



This example assumes `using Recraft;` is in scope and `apiKey` contains your Recraft API key.

```csharp
using var client = new RecraftClient(apiKey);

GenerateImageResponse response = await client.Image.GenerateImageAsync(
    request: new GenerateImageRequest
    {
        Prompt = "A serene mountain landscape at sunset",
        Size = ImageSize.x1024x1024,
    });

foreach (var image in response.Data ?? [])
{
    Console.WriteLine($"Image URL: {image.Url}");
}
```