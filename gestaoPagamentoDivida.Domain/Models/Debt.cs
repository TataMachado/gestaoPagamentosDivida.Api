using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentosDivida.Domain.Contracts
    ;

namespace gestaoPagamentoDivida.Domain.entitys
{
    public class Debt: Entity
    {
        public decimal Amount  { get; set; }

        public DateTime DueDate { get; set; }
        public Models.Debtor Debtor { get; set; }
        public DateTime CreationDate { get; set; }
        public Payment Payment { get; set; }
      
          
       
        public Debt()
        {

        }

        public Debt(decimal amont, DateTime dueDate, Models.Debtor debtor)
        {
            Amount= amont;
            DueDate= dueDate;   
            debtor = debtor; 
            
        }
       
    }
}