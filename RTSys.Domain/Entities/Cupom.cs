using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Domain.Entities
{
    public class Cupom
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Premiado { get; set; }
    }
}
