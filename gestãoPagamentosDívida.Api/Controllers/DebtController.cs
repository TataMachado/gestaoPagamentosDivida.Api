using FluentValidation;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentoDivida.Domain.Models.Validators;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;


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
    [HttpGet("Id")]
    public async Task<ActionResult> IndexId(string Id)
    {

        var Result = repositoryDebt.entityGet(Id);
        return Ok(Result);
    }



    [HttpDelete("/Debt/{Id}")]
    public async Task<ActionResult> Deletar( [FromRoute] string id)
    {

        return Ok();
        

    }

    [HttpPost]
    public async Task<ActionResult> CriandoDebt([FromBody] Debt debt)
    {
        
        
            //var validationResult = new DebtValidation().ValidateAndThrowAsync(contract );
            

             repositoryDebt.Add(debt);
            return Ok(debt);


        
       



    }
}