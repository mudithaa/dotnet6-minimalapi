var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

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
