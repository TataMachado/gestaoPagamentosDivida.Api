namespace gestaoPagamentosDivida.Domain.Contracts

{
    public class DebtorRequest
    {
        public string Name {get; set;}  
        public string Document { get; set; }
        public DebtorRequest()
        {

        }
        public Guid Id { get; set; }
    }
}
