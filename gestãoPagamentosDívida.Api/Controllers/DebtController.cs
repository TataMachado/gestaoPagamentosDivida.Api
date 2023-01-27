using FluentValidation;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;
using gestaoPagantoDivida.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Numerics;

namespace gestãoPagamentosDívida.Api.Controllers;

[ApiController]
[Route("/Debt")]
public class DebtController : ControllerBase
{
    private readonly IRepositoryDebt repositoryDebt;
    private readonly IRepositoryPayment repositoryPayment;


    public DebtController(IRepositoryDebt repositoryDebt, IRepositoryPayment repositoryPayment)
    {
        this.repositoryDebt = repositoryDebt;
        this.repositoryPayment = repositoryPayment;
    }

    [HttpGet]

    public async Task<ActionResult> index()
    {
        var Result = repositoryDebt.GetAll();


        return Ok(Result);

    }
    [HttpGet("{Id}")]
    public async Task<ActionResult> IndexId([FromRoute] Guid Id)
    {
        var Result = repositoryDebt.GetId(Id);
        
      
        return Ok(Result);
    }

    
    [HttpDelete("/Debt/{Id}")]
    public async Task<ActionResult> Deletar([FromRoute] Guid Id)
    {
        var  result =  repositoryDebt.DeleteDebitsId(Id);
        return Ok("Excluido com sucesso");


    }
    

    [HttpPost]
    public async Task<ActionResult> CriandoDebt([FromBody] DebtRequest debtRequest)
    {

        var debtValidation = new DebtValidation();
        await debtValidation.ValidateAndThrowAsync(debtRequest);
        Debt debt1 = new Debt();
        
     
        debt1.Amount = debtRequest.Amount;
        debt1.CreationDate = DateTime.Now;
        debt1.Debtor = new Debtor(debtRequest.Debtor.Name, debtRequest.Debtor.Document);
        debt1.DueDate = debt1.DueDate;
        Debtor debtor = new(debtRequest.Debtor.Name, debtRequest.Debtor.Document);
        
       
     
            

        debtor.Debt = debt1;

        repositoryDebt.Add(debt1);
        
        
                                                                                                     
        
        return Ok(debt1);



    }

}

    
