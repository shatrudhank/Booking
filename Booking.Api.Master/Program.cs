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

builder.Services.AddCors((options) =>{
    options.AddDefaultPolicy((policy) =>
    {
        policy.WithOrigins(builder.Configuration.GetSection("AllowedOrigin").Get<string[]>())
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IRepository<Country>, CountryRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
