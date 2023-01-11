
using FluentValidation;
using gestaoPagamentoDivida.Domain.Models.Validators;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagantoDivida.Repository;
using gestaoPagantoDivida.Repository.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlDatabaseContext>(opt=>opt.UseInMemoryDatabase("gestaoPagamentos"));
builder.Services.AddScoped<IValidator<gestaoPagamentoDivida.Domain.Models.Debtor>, DebtorValidation>();

builder.Services.AddScoped<IRepositoryDebt, RepositoryDebt>();
builder.Services.AddScoped<IRepositoryDebtor, RepositoryDebtor>();
builder.Services.AddScoped<IRepositoryPayment, RepositoryPayment>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers( );

app.Run();
