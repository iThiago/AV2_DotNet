using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Processo
    {
        public long ProcessoId { get; set; }
        public string FiscalResponsavel { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public long FornecedorId { get; set; }
        public DateTime DataRelato { get; set; }
        public StringBuilder RelatoFiscalizacao { get; set; }
        public virtual AutoInfracao AutoInfracao { get; set; }
        public long AutoInfracaoId { get; set; }

        public readonly String _numeroProcesso;

        public String NumeroProcesso()
        {

            if (DataRelato != null && Fornecedor != null)
            {
                return DataRelato.ToString("yyyy/MM/dd/HH/mm/ss").Replace("/", "") + Fornecedor.Cnpj.Replace(".","");
            }

            return "";

        }
        

    }
}
