using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BeerWithFriendsBackend.Data;
using BeerWithFriendsBackend.Logic;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BeerWithFriendsBackendContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BeersCon") ?? throw new InvalidOperationException("Connection string 'BeerWithFriendsBackendContext' not found.")));

builder.Services.AddDbContext<BeerWithFriendsBackendContext>(options =>
{
    options.UseSqlServer(r => r.EnableRetryOnFailure(
        maxRetryCount: 10,
        maxRetryDelay: TimeSpan.FromSeconds(30),
        errorNumbersToAdd: null
    ));
});
builder.Services.AddCors();
builder.Services.AddTransient<BeerData>();
builder.Services.AddTransient<BeerLogic>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});

app.MapControllers();

app.Run();
