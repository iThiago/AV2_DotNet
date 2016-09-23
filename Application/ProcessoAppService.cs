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
    public class ProcessoAppService : AppServiceBase<Processo>, IProcessoAppService
    {
        private readonly IProcessoService _ProcessoService;

        public ProcessoAppService(IProcessoService ProcessoService) : base(ProcessoService)
        {
            _ProcessoService = ProcessoService;
        }
    }
}
