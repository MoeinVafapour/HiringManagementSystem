using AutoMapper;
using HiringManagementSystem.Models.DomainModels.Aggregates;
using HiringManagementSystem.Models.ViewModels.Dtos;

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
