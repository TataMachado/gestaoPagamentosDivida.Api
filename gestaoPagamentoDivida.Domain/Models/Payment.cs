using gestaoPagamentoDivida.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.entity
{
    public class Payment: Entity
    {
        public decimal Amount_payment { get; set; }
        public DateTime Date_payment { get; set; }

        public Payment()
        {

        }
    }
}
