var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
var app = builder.Build();

app.MapGet("/", () => "API Gateway de Microservicios IA");
app.MapGet("/tasks", async (IHttpClientFactory clientFactory) =>
{
    var client = clientFactory.CreateClient();
    var response = await client.GetStringAsync("http://task-service/tasks");
    return Results.Ok(response);
});

app.Run();
