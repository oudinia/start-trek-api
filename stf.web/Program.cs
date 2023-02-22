using DotNetCore.EntityFrameworkCore;
using DotNetCore.IoC;
using DotNetCore.Mediator;
using Microsoft.EntityFrameworkCore;
using stf.DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddContext<StarFleetDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("sftConnection")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddClassesMatchingInterfaces(nameof(stf));

builder.Services.AddMediator(nameof(stf));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSwagger().UseSwaggerUI();
app.UseRouting();
app.MapControllers();
app.Run();