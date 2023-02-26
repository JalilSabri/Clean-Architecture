using CleanArch.Core.Contracts.IServices.Persons;
using CleanArch.Core.Application.Services.Persons;
using CleanArch.Core.Contracts.IRepositories.Persons;
using CleanArch.Infrastructure.Data.Repositories.Persons;
using CleanArch.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

ConfigurationManager Configuration = builder.Configuration;

builder.Services.AddDbContext<CleanArchDbContext>(option => {
    option.UseSqlServer("Server=DESKTOP-98REPCN\\SQL2019DEVELOPER; Database=ArchitectureDB; User ID=sa; Password=123");
});

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();



#region .:| Comment |:.

//app.MapGet("/", () => "Hello World!");
//app.MapPost("/", () => "This is a post method!");
//----------------------------------------------------------------------

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute("MVC-Map", "{controller=Home}/{action=Index}/{id?}");
//});

#endregion