using RTSys.Domain.Entities;
using RTSys.Domain.Interfaces.Repositories;
using RTSys.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Domain.Services
{
    public class CupomService : ServiceBase<Cupom>, ICupomService
    {
        private readonly ICupomRepository _cupomRepository;

        public CupomService(ICupomRepository cupomRepository)
            : base(cupomRepository)
        {
            _cupomRepository = cupomRepository;
        }

    }
}
