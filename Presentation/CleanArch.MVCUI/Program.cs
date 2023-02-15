using CleanArch.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var vv = builder.Configuration.GetConnectionString("CleanArchDB");

//IConfiguration configuration = builder.Configuration;
builder.Services.AddDbContext<CleanArchDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("CleanArchDB"));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
