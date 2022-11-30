using AutoMapper;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using OData;
using OData.Data;
using OData.Helper;
using OData.Services;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DefaultConnection");
var model2 = EdmBuilder.GetEdmModel();
var mapper = CustomMapperConfiguration.GetMapperConfiguration();


// Add services to the container.
builder.Services.AddDbContext<FIFAWorldCupApiContext>(options => options.UseSqlServer(connString));

builder.Services
    .AddControllers()
    .AddOData(options => {
        options
        .EnableQueryFeatures()
        .AddRouteComponents("api/v2", model2);
    });




// Configured DI
builder.Services.AddTransient<IFIFAWorldCupService, FIFAWorldCupService>();
builder.Services.AddSingleton(mapper);


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

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
