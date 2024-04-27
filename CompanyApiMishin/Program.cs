using Microsoft.EntityFrameworkCore;
using CompanyApiMishin.Models;

var builder = WebApplication.CreateBuilder(args);

const string conn = "Server =(localdb)\\mssqllocaldb; Database = CompanyDB; Trusted_Connection = True; TrustServerCertificate = True; ";

builder.Services.AddControllers();
builder.Services.AddDbContext<Context>(opt =>
    opt.UseSqlServer(conn));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
