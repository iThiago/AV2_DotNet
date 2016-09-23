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
    public class ProcessoService : ServiceBase<Processo>, IProcessoService
    {
        private readonly IProcessoRepository _ProcessoRepository;

        public ProcessoService(IProcessoRepository processoRepository) : base (processoRepository)
        {
            _ProcessoRepository = processoRepository;
        }
    }
}
