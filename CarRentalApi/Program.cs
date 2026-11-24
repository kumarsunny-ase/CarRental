using CarRentalApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ICarRentalService, CarRentalService>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(Options =>
{
    Options.AllowAnyHeader();
    Options.AllowAnyMethod();
    Options.AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
