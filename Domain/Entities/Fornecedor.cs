using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoMunicipal { get; set; }
        public int ReceitaBruta { get; set; }
        public List<Endereco> Endereco { get; set; }
        public List<Processo> Processos { get; set; }
    }
}
