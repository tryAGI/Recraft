# Get Current User



This example assumes `using Recraft;` is in scope and `apiKey` contains your Recraft API key.

```csharp
using var client = new RecraftClient(apiKey);

User user = await client.User.GetCurrentUserAsync();

Console.WriteLine($"User ID: {user.Id}");
Console.WriteLine($"Name: {user.Name}");
Console.WriteLine($"Email: {user.Email}");
Console.WriteLine($"Credits: {user.Credits}");
```