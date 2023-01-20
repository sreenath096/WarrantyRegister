using Microsoft.EntityFrameworkCore;
using warrantyRegisterAPI.DataContext;
using warrantyRegisterAPI.Repository;
using warrantyRegisterAPI.Repository.Contract;
using warrantyRegisterAPI.Service;
using warrantyRegisterAPI.Service.Contract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<InMemoryDataContext>(options =>
{
    options.UseInMemoryDatabase("WarrantyRegisterationDb");
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IServiceFactory, ServiceFactory>();
builder.Services.AddScoped<IRepositoryFactory, RepositoryFactory>();

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
