using Microsoft.EntityFrameworkCore;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Infrastructure.Data.Repositories.Persons;
using CleanArch.Core.Contracts.IRepositories.Persons;
using CleanArch.Core.Contracts.IServices.Persons;
using CleanArch.Core.Application.Services.Persons;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddDbContext<CleanArchDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("CleanArchDB"));
});

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    //endpoints.MapControllers();
    endpoints.MapControllerRoute("default", "{Controller=Home}/{Action=Index}/{id?}");
});
app.UseStaticFiles();
app.Run();



#region .:| Commit |:.

//IConfiguration configuration = builder.Configuration;

#endregion