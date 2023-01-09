using FluentValidation;
using gestaoPagamentoDivida.Domain.Contracts;
using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models.Validators;
using gestaoPagamentoDivida.Domain.Repository.Interfaces;
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
        [HttpPost("/id")]
        public async  Task<ActionResult> IndexId(Guid Id)
        {
            var result = repositoryPayment.GetAllId(Id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<AcceptedResult> CriandoPayment([FromBody] PaymentContract paymentRequst)
        {
            Payment payment1=new Payment();
            payment1.Amount_payment = paymentRequst.Amount_payment;
            payment1.Date_payment = paymentRequst.Date_payment;
            var validationResult = new PaymentValidation().ValidateAndThrowAsync(payment1);
            repositoryPayment.Add(payment1);
            return Ok(payment1);
        }
    
    }
}
