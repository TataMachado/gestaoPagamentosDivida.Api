using gestaoPagamentoDivida.Domain.entity;
using gestaoPagamentoDivida.Domain;
using gestaoPagamentoDivida.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gestaoPagamentosDivida.Api.Requests
{
    public class DebtorRequest 
    {
        [Required(ErrorMessage ="O campo nome é obrigatório")]
        [MinLength(5, ErrorMessage = "O nome precisa ter no minimo 5 cacteres")]
        public string Name { get; set; }
        [Required(ErrorMessage ="O campo documento é obrigatório")]
        [MinLength(5, ErrorMessage ="O documento precisa ter no minimo 5 cacteres")]
        
        public string Document { get; set; }

        

        public DebtorRequest() { }
      

    }
    

}
