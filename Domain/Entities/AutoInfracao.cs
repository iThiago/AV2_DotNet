using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class AutoInfracao
    {
        public int AutoInfracaoId { get; set; }
        public Processo Processo { get; set; }
        public int Gravidade { get; set; }
        public bool Atenuante { get; set; }
        public bool Agravante { get; set; }
        public Decimal Multa { get; set; }
        
    }
}
