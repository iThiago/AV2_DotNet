using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Service;

namespace Application
{
    public class FornecedorAppService : AppServiceBase<Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _FornecedorService;

        public FornecedorAppService(IFornecedorService FornecedorService) : base(FornecedorService)
        {
            _FornecedorService = FornecedorService;
        }
    }
}
