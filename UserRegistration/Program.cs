using Microsoft.EntityFrameworkCore;
using UserCore.Implementation;
using UserCore.Interface;
using UserInfrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("UserDb");
builder.Services.AddDbContext<UserDBcontext>(option => option.UseSqlServer(connection));

builder.Services.AddScoped<IUserPost, UserPost>();
builder.Services.AddScoped<IUserPut, UserPut>();
builder.Services.AddScoped<IUserDelete, UserDelete>();
builder.Services.AddScoped<IUserGet, UserGet>();

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
