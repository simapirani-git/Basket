var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => Results.Text("I AM BASKET", "text/plain"));

app.MapControllers();

app.Run();