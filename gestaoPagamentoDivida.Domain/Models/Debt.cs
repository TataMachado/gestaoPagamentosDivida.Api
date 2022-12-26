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
        public Debtor Debtor { get; set; }
        public DateTime CreationDate { get; set; }
        public Debt()
        {

        }

        public Debt(decimal amont, DateTime dueDate, Debtor debtor )
        {
            Amount= amont;
            DueDate= dueDate;   
            Debtor= debtor; 
        }
    }
}