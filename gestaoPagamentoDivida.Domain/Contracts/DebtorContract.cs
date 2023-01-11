using gestaoPagamentoDivida.Domain.Contracts;
using gestaoPagamentoDivida.Domain.entity;
using System.Text.Json.Serialization;

namespace gestaoPagamentosDivida.Domain.Contracts

{
    public class DebtorContract
    {
        public string Name {get; set;}  
        public string Document { get; set; }
        [JsonIgnore]
        public Payment Payment { get; set; }


    }
}
