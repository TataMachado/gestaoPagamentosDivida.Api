using FluentValidation;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentoDivida.Domain.Models.Validators;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
namespace gestãoPagamentosDívida.Api.Controllers;

[ApiController]
[Route("/Debt")]
public class DebtController : ControllerBase
{
    private readonly IRepositoryDebt repositoryDebt;


    public DebtController(IRepositoryDebt repositoryDebt)
    {
        this.repositoryDebt = repositoryDebt;


    }

    [HttpGet]

    public async Task<ActionResult> index()
    {
        var Result = repositoryDebt.GetAll();


        return Ok(Result);

    }
    [HttpGet("{Id}")]
    public async Task<ActionResult> IndexId([FromRoute]Guid Id)

    {
     

        var Result = repositoryDebt.DeleteDebitsId(Id);
        return Ok(Result);
    }



    [HttpDelete("/Debt/{Id}")]
    public async Task<ActionResult> Deletar( [FromRoute] Guid Id)
    {
        var result = repositoryDebt.DeleteDebitsId(Id);
        return Ok(result);
        

    }

    [HttpPost]
    public async Task<ActionResult> CriandoDebt([FromBody] DebtContract debtRequest)
    {
        
        
 
        Debt debt1 = new Debt();
        debt1.Amount = debtRequest.Amount;
        debt1.CreationDate = DateTime.Now;
        debt1.Debtor= new Debtor(debtRequest.Debtor.Name, debtRequest.Debtor.Document);
        debt1.DueDate = debt1.DueDate;
        //var validationResult = new DebtValidation().ValidateAndThrowAsync(debt1);
        repositoryDebt.Add(debt1);
            return Ok(debt1);


        
       



    }
}