using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;
using System.Text.Json.Serialization;

namespace gestaoPagamentoDivida.Domain.entity
{
    public class Payment: Entity
    {
        public decimal Amount_payment { get; set; }
        public DateTime Date_payment { get; set; }
        
        public Debt Debt { get; set; } 
        

        public Payment()
        {
                
        }
      
        public Payment(decimal amount_payment, DateTime date_payment)
        {
            Amount_payment = amount_payment;
            Date_payment = date_payment;
           
        }
    }
}
