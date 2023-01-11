using gestaoPagamentoDivida.Domain.Models;


namespace gestaoPagamentoDivida.Domain.entity
{
    public class Payment: Entity
    {
        public decimal Amount_payment { get; set; }
        public DateTime Date_payment { get; set; }
        public Debtor Debtor { get; set; }  
        public Payment()
        {

        }
        public Payment(decimal amount_payment, DateTime date_payment, Debtor debtor)
        {
            Amount_payment = amount_payment;
            Date_payment = date_payment;
            Debtor = debtor;
        }
    }
}
