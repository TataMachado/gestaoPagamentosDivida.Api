using gestaoPagamentoDivida.Domain.Models;
using gestaoPagamentosDivida.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.Contracts
{
    public class PaymentContract
    {
        public decimal Amount_payment { get; set; } 
        public DateTime Date_payment { get; set; }
        [JsonIgnore]
        public Debtor Debtor { get; set; }

    }
}
