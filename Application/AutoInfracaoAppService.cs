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
    public class AutoInfracaoAppService : AppServiceBase<AutoInfracao>, IAutoInfracaoAppService
    {
        private readonly IAutoInfracaoService _AutoInfracaoService;

        public AutoInfracaoAppService(IAutoInfracaoService AutoInfracaoService) : base(AutoInfracaoService)
        {
            _AutoInfracaoService = AutoInfracaoService;
        }
    }
}
