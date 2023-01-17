using FluentValidation;
using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Api.Requests;
using gestaoPagamentosDivida.Api.Validator;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("/{id}")]
        public async  Task<ActionResult> IndexId(Guid Id)
        {
            var result = repositoryPayment.GetAllId(Id);
            return Ok(result);
        }
       [HttpPost]
        public async Task<ActionResult> CriandoPayment([FromRoute]Guid Id,[FromBody] PaymentRequest paymentRequset)
        {
            Payment payment1=new Payment();
          
           payment1.Amount_payment = paymentRequset.Amount_payment;

            var resutValidation =new PaymentValidation().ValidateAndThrowAsync(paymentRequset);
            var debtor = repositoryDebt.GetAll(Id);
            payment1.Debt = debtor;
             
            repositoryPayment.Add(payment1);
         
                return Ok(payment1);
        }
    
    }
}
