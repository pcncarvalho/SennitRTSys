using AutoMapper;
using RTSys.Domain.Entities;
using RTSys.Web.ViewModels;

namespace RTSys.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
        }
    }
}