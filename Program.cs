using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

# region Swagger / build
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API");
});
# endregion
app.MapGet("/", () => "Hello World!");

app.MapGet("/books", () => {
    return BookService.Books;
});

app.Run();
