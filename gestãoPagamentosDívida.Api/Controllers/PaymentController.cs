using FluentValidation;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace gestaoPagamentosDivida.Api.Controllers
{
    [ApiController]
    [Route("/Payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IRepositoryPayment repositoryPayment; IRepositoryDebt repositoryDebt;
        public PaymentController(IRepositoryPayment repositoryPayment, IRepositoryDebt repositoryDebt)
        {
            this.repositoryPayment = repositoryPayment;
            this.repositoryDebt = repositoryDebt;   
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var result = repositoryPayment.GetAll();
            return Ok(result);
        }
        [HttpGet("{Id}")]
        public async  Task<ActionResult>  IndexId([FromRoute] Guid Id)
        {
            var result = await repositoryPayment.GetAll(Id);
            return Ok(result);
        }
        [HttpDelete("{Id}")]
        public async Task <ActionResult> Deletar(Guid Id)
        {
            var rsult = repositoryPayment.DeleteId( Id);
            return Ok("Excluido com sucesso");   
        }
       [HttpPost("Payment/{Id}")]
        public async Task<ActionResult> CriandoPayment([FromRoute]Guid Id, PaymentRequest paymentRequset)
        {
            var paymentValidation = new PaymentValidation();
           await paymentValidation.ValidateAndThrowAsync(paymentRequset);

            Payment payment1=new Payment();

          
           payment1.Amount_payment = paymentRequset.Amount_payment;
            


            var debt=await repositoryDebt.GetAll(Id);
            
            debt.CalcularDivida(payment1.Amount_payment);
            payment1.Debt = debt;


        
 
             
            repositoryPayment.Add(payment1);
            repositoryDebt.Update(debt);
         
                return Ok(payment1);
        }
    
    }
}
