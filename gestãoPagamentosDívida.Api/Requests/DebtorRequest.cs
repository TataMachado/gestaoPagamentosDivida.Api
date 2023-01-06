using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentoDivida.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestaoPagamentosDivida.Api.Requests
{
    public class DebtorRequest 
    {
        
        public string Name { get; set; }
        public string Document { get; set; }
      

    }
    

}
