using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;
using System.Text.Json.Serialization;

namespace gestaoPagamentoDivida.Domain.entity
{
    public class Payment: Entity
    {
        public decimal amount { get; set; }
        public DateTime date { get; set; }
        [JsonIgnore]
        public Debt Debt { get; set; }
        

        public Payment()
        {
                
        }
      
        public Payment(decimal amount, DateTime date)
        {
            this.amount = amount;
            this.date = date;
           
        }
    }
}
