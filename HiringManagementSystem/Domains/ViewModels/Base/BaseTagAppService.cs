using AutoMapper;
using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Services.Abstracts;
using HiringManagementSystem.Domains.ViewModels.Abstarct;
using HiringManagementSystem.Domains.ViewModels.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.ViewModels.Base
{
    public class BaseTagAppService : ITagAppService
    {
        public BaseTagAppService(ITagRepository tagRepository, Mapper mapper)
        {
            TagRepository = tagRepository;
            Mapper = mapper;
        }

        public ITagRepository TagRepository { get; }
        public Mapper Mapper { get; }

        public async Task DeleteAsync(int id)
        {
            await TagRepository.DeleteAsync(id);
        }

        public async Task<TagDtoViewModel> FindByIdAsync(int id)
        {
            var tag = await TagRepository.FindByIdAsync(id);
            return Mapper.Map<TagAggregate, TagDtoViewModel>(tag);
        }

        public async Task<List<TagDtoViewModel>> GetAllAsync()
        {
            var tags = await TagRepository.GetAllAsync();
            return Mapper.Map<List<TagDtoViewModel>>(tags);
        }

        public async Task InsertAsync(TagDtoViewModel tagDto)
        {
            var tag = Mapper.Map<TagDtoViewModel, TagAggregate>(tagDto);
            await TagRepository.InsertAsync(tag);
        }

        public async Task UpdateAsync(TagDtoViewModel tagDto)
        {
            var tag = Mapper.Map<TagDtoViewModel, TagAggregate>(tagDto);
            await TagRepository.UpdateAsync(tag);
        }
    }
}
