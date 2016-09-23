using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.EntityConfiguration
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(p => p.FornecedorId);
            Property(p => p.Cnpj).IsRequired().HasMaxLength(150);
            Property(p => p.InscricaoMunicipal).IsRequired().HasMaxLength(150);
            Property(p => p.RazaoSocial).IsRequired();
        }

    }
}
