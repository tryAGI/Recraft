# List Basic Styles



This example assumes `using Recraft;` is in scope and `apiKey` contains your Recraft API key.

```csharp
using var client = new RecraftClient(apiKey);

ListBasicStylesResponse response = await client.Style.ListBasicStylesAsync();

foreach (var style in response.Styles)
{
    Console.WriteLine($"Style: {style.Style} (Model: {style.Model})");
}
```