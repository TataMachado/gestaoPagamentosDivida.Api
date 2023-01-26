
using FluentValidation;
using FluentValidation.AspNetCore;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;
using gestaoPagantoDivida.Repository;
using gestaoPagantoDivida.Repository.Mappings;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlDatabaseContext>(opt=>opt.UseInMemoryDatabase("gestaoPagamentos"));

    
void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();

   
    builder.Services.AddControllers().AddFluentValidation();
    builder.Services.AddTransient<IValidator <DebtorRequest>,DebtorValidation>();
    builder.Services.AddScoped<IValidator<PaymentRequest>,PaymentValidation> ();
    builder.Services.AddTransient<IValidator< DebtRequest >,DebtValidation> ();


  





}

builder.Services.AddScoped<IRepositoryDebt, RepositoryDebt>();
builder.Services.AddScoped<IRepositoryDebtor, RepositoryDebtor>();
builder.Services.AddScoped<IRepositoryPayment, RepositoryPayment>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers( );

app.Run();
