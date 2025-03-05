using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mmsys.ProductManagementApi.Config;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Repository;
using Mmsys.ProductManagementApi.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];

builder.Services.AddDbContext<MySQLContext>(opt =>
{
    DbContextOptionsBuilder dbContextOptionsBuilder = opt.UseMySql(connection, new MySqlServerVersion(new Version()));
});

IMapper mapper = MappingConfig.RegistrerMaps().CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ISalesRepository, SalesRepository>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
