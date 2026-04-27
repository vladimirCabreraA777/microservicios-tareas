var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/ai/generate", (string phrase) => 
{
    return Results.Ok(new { 
        title = $"Tarea: {phrase}", 
        priority = "media",
        suggestedDate = DateTime.Now.AddDays(2)
    });
});

app.Run();
