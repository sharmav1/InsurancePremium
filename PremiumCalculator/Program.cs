using PremiumCalculator.Api.Common;
using PremiumCalculator.Core.Customers;
using PremiumCalculator.Core.Occupations;
using PremiumCalculator.Core.Ratings;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
builder.Services.AddControllers();
builder.Services.AddScoped<IGetCustomerMonthlyPremium, GetCustomerMonthlyPremium>();
builder.Services.AddScoped<IOccupationQuery, GetOccupations>();
builder.Services.AddScoped<IGetRatingsQuery, GetRatings>();
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

app.MapControllers();

app.Run();
