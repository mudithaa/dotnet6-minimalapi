var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(o => 
{
    o.SwaggerEndpoint("/swagger/v1/swagger.json", "Minimal API");
    o.RoutePrefix = string.Empty;
});

app.MapGet("/customers", () => {
    return new[]
    {
        new {
            CustomerId = 1,
            Name = "Joe Bloggs",
        },
        new {
            CustomerId = 2,
            Name = "Jane Blog not",
        }
    };
});

app.MapGet("/customers/{id}", (int id) => {
    return new
    {
        CustomerId = 1,
        Name = "Joe Bloggs",
    };
});

app.MapGet("/products", () => {
    return new
    {        
        Name = "Pixel 6 sdfsdfs df",
    };
});

app.Run();
