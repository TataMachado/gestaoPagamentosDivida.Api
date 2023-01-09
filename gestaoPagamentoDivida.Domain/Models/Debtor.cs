using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentosDivida.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.Models
{
    public class Debtor: Entity
    {
        
        public string Name { get; set; }
        public string Document { get; set;}
        public Debt Debt { get; set; }
        public Debtor()
        {

        }


        public Debtor(string name, string document, Debt debt) { 
            Name = name;    
            Document = document;
            Debt = debt;

        }

    }
    
}
