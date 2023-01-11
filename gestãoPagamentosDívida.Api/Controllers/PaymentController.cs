using FluentValidation;
using gestaoPagamentoDivida.Domain.Contracts;
using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models.Validators;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
using gestaoPagamentosDivida.Api.Requests;
using Microsoft.AspNetCore.Mvc;

namespace gestaoPagamentosDivida.Api.Controllers
{
    [ApiController]
    [Route("/Payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IRepositoryPayment repositoryPayment;
        public PaymentController(IRepositoryPayment repositoryPayment) {
            this.repositoryPayment = repositoryPayment;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var result = repositoryPayment.GetAll();
            return Ok(result);
        }
        [HttpGet("/id")]
        public async  Task<ActionResult> IndexId(Guid Id)
        {
            var result = repositoryPayment.GetAllId(Id);
            return Ok(result);
        }
       [HttpPost]
        public async Task<ActionResult> CriandoPayment([FromBody] Payment paymentRequst)
        {
            Payment payment1=new Payment();
          
            payment1.Debtor.Payment.Amount_payment= paymentRequst.Amount_payment;
            payment1.Debtor.Payment.Date_payment= paymentRequst.Date_payment;
            var validationResult = new PaymentValidation().ValidateAndThrowAsync(paymentRequst);
            repositoryPayment.Add(payment1);
            return Ok(payment1);
        }
    
    }
}
