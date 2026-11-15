using GameStore.Application.Features.Catalog;
using GameStore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddInfrastructure();
builder.Services.AddScoped<ProductService>();

// CORS: permite que la web (Vite) llame a la API durante el desarrollo.
const string WebCors = "WebCors";
builder.Services.AddCors(options =>
    options.AddPolicy(WebCors, policy =>
        policy.WithOrigins("http://localhost:5173")
    .AllowAnyHeader()
    .AllowAnyMethod()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
else
{
    app.UseHttpsRedirection();
}

app.UseCors(WebCors);
app.UseAuthorization();
app.MapControllers();

app.Run();