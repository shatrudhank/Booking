using Booking.Api.Master.Repository;
using Booking.Api.Master.Repository.Entity;
using Booking.Api.Master.Repository.IRepository;
using Booking.Api.Master.Repository.Repository;
using Booking.Api.Master.Services;
using Booking.Api.Master.Services.IService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AdminDbContext>((option) =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));
});
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IRepository<Country>, CountryRepository>();


var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
