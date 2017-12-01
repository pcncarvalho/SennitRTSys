using RTSys.Application.Interfaces;
using RTSys.Domain.Entities;
using RTSys.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Application.Services
{
    public class ClienteAppService : AppServiceBase<Domain.Entities.Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        
    }
}
