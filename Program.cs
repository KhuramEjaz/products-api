var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var products = new[]
{
    new { Id = 1, Name = "Keyboard", Price = 25.50m },
    new { Id = 2, Name = "Mouse", Price = 12.00m },
    new { Id = 3, Name = "Monitor", Price = 180.00m }
};

app.MapGet("/health", () => Results.Ok(new { status = "healthy", time = DateTime.UtcNow }));

app.MapGet("/api/products", () => Results.Ok(products));

app.Run();