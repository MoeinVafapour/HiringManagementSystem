using AutoMapper;
using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.ViewModels.Dtos;

namespace HiringManagementSystem.Profiles
{
    public class AutoMapperProfile : Profile
    {
        #region [- Ctor -]
        public AutoMapperProfile()
        {
            CreateMap<PersonAggregate, PersonDtoViewModel>().ReverseMap();
            CreateMap<TagAggregate, TagDtoViewModel>().ReverseMap();
        } 
        #endregion
    }
}
