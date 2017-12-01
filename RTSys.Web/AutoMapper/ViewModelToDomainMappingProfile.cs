using AutoMapper;
using RTSys.Domain.Entities;
using RTSys.Web.ViewModels;

namespace RTSys.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}