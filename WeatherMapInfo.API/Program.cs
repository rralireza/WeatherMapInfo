using Scalar.AspNetCore;
using WeatherMapInfo.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configuration();

builder.Configuration.AddUserSecrets<Program>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
