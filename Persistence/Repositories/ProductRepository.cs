using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Persistence.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProfuctRepository 
    {

    }
}
