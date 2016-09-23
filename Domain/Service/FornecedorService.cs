using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Service
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _FornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository) : base (fornecedorRepository)
        {
            _FornecedorRepository = fornecedorRepository;
        }
    }
}
