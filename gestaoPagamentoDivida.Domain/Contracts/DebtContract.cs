using gestaoPagamentoDivida.Domain.Contracts;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;
using System.Text.Json.Serialization;

namespace gestaoPagamentosDivida.Domain.Contracts

{
    public class DebtContract
    {
        public decimal Amount { get; set; }
     
       
       public DebtorContract Debtor { get; set; }
        [JsonIgnore]
       // public PaymentContract Payment { get; set; }

        

        
        public DateTime DueDate { get; set; }

       
    
    }
}
