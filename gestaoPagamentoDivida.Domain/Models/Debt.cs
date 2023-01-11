using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentosDivida.Domain.Contracts
    ;
using System.Text.Json.Serialization;

namespace gestaoPagamentoDivida.Domain.entitys
{
    public class Debt: Entity
    {
        public decimal Amount  { get; set; }

        public DateTime DueDate { get; set; }
        public Models.Debtor Debtor { get; set; }
        public DateTime CreationDate { get; set; }
        [JsonIgnore]
        public List<Payment> Payments { get; set; }
      
          
       
        public Debt()
        {

        }

        public Debt(decimal amont, DateTime dueDate, Models.Debtor debtor)
        {
            Amount= amont;
            DueDate= dueDate;   
            debtor = debtor; 
            
        }
        public decimal CalcularDivida(decimal Amount_payment)
        {
            return Amount-=Amount_payment;
        }
       
    }
}