using Entities;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Repositories;
using RepositoryContracts;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CompanyDbContext>(
       option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

builder.Services.AddScoped<IEmployeesRepository, EmployeesRepository>();

builder.Services.AddHttpLogging(options => {
    options.LoggingFields = HttpLoggingFields.RequestProperties | HttpLoggingFields.ResponsePropertiesAndHeaders;
    });

builder.Host.UseSerilog((HostBuilderContext ctx, IServiceProvider service, LoggerConfiguration loggerConfiguration) =>
{
    loggerConfiguration
        .ReadFrom.Configuration(ctx.Configuration)
        .ReadFrom.Services(service);
});


var app = builder.Build();

app.UseHttpLogging();

app.MapControllers();

app.Run();
