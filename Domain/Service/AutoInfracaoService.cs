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
    public class AutoInfracaoService : ServiceBase<AutoInfracao>, IAutoInfracaoService
    {
        private readonly IAutoInfracaoRepository _AutoInfracaoRepository;

        public AutoInfracaoService(IAutoInfracaoRepository autoInfracaoRepository) : base (autoInfracaoRepository)
        {
            _AutoInfracaoRepository = autoInfracaoRepository;
        }
    }
}
