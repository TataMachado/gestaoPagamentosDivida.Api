using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain.entitys;
using gestaoPagamentosDivida.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestaoPagamentoDivida.Domain.Models
{
    public class Debtor: Entity
    {
        
        public string Name { get; set; }
        public string Document { get; set;}
        [JsonIgnore]
        public Debt Debt { get; set; }
        [JsonIgnore]
        public Payment Payment { get; set; }



        public Debtor()
        {

        }
       

        public Debtor(string name, string document) { 
            Name = name;    
            Document = document;
            
            
            

        }

    }
    
}
