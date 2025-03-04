using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mmsys.ProductManagementApi.Config;
using Mmsys.ProductManagementApi.Model.Context;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];

builder.Services.AddDbContext<MySQLContext>(opt =>
{
    DbContextOptionsBuilder dbContextOptionsBuilder = opt.UseMySql(connection, new MySqlServerVersion(new Version()));
});

IMapper mapper = MappingConfig.RegistrerMaps().CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseAuthorization();

app.MapControllers();

app.Run();
