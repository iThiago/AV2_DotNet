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
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProfuctRepository _productRepository;

        public ProductService(IProfuctRepository produtoRepository) : base (produtoRepository)
        {
            _productRepository = produtoRepository;
        }
    }
}
