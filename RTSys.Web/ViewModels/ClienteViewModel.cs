using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RTSys.Web.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome do Cliente deve ser informado!")]
        public string Nome { get; set; }


        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
    }
}