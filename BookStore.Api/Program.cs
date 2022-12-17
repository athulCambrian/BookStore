using BookApi.Data;
using BookApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<ShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopBookOnlineConnection"))
);

builder.Services.AddScoped<IProductRepository, ProductRepoImpl>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
policy.WithOrigins("http://localhost:7144", "https://localhost:7144")
.AllowAnyMethod()
.WithHeaders(HeaderNames.ContentType)
    );
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
