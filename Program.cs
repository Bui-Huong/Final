using Back_end.DB;
using Back_end.Interface;
using Back_end.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer("name=ConnectionStrings:MyConnection").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IAssetService, AssetService>();
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
