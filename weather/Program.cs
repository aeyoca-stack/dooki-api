var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

var app = builder.Build();



app.MapGet("/roll", () =>
{
    var random = new Random();
    var roll = random.Next(1, 7);
    return roll;
});

app.Run();