using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;
using System.Text.Json.Serialization;

namespace gestaoPagamentoDivida.Domain
{
    public class Debt: Entity
    {
        private decimal amount_payment;

        public decimal Amount  { get; set; }

        public DateTime DueDate { get; set; }
        public Models.Debtor Debtor { get; set; }
        public DateTime CreationDate { get; set; }
        
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

        public Debt(decimal amount_payment)
        {
            this.amount_payment = amount_payment;
        }

        public decimal CalcularDivida(decimal Amount_payment)
        {
            return Amount -= Amount_payment;
        }

    }
}