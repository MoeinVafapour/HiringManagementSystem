using AutoMapper;
using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Services.Abstracts;
using HiringManagementSystem.Domains.ViewModels.Abstarct;
using HiringManagementSystem.Domains.ViewModels.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.ViewModels.Base
{
    public class BasePersonAppService : IPersonAppService
    {
        public BasePersonAppService(IPersonRepository personRepository, IMapper mapper)
        {
            PersonRepository = personRepository;
            Mapper = mapper;
        }

        public IPersonRepository PersonRepository { get; set; }
        public IMapper Mapper { get; set; }

        public async Task DeleteAsync(int id)
        {
            await PersonRepository.DeleteAsync(id);
        }

        public async Task<PersonDtoViewModel> FindByIdAsync(int id)
        {
            var person = await PersonRepository.FindByIdAsync(id);
            return Mapper.Map<PersonDtoViewModel>(person);
        }

        public async Task<List<PersonDtoViewModel>> GetAllAsync()
        {
            var person = await PersonRepository.GetAllAsync();
            return Mapper.Map<List<PersonDtoViewModel>>(person);
        }

        public async Task InsertAsync(PersonDtoViewModel personDto)
        {
            var person =  Mapper.Map<PersonDtoViewModel,PersonAggregate>(personDto);
            await PersonRepository.InsertAsync(person);
        }

        public async Task UpdateAsync(PersonDtoViewModel personDto)
        {
            var person = Mapper.Map<PersonDtoViewModel, PersonAggregate>(personDto);
            await PersonRepository.UpdateAsync(person);
        }

        public async Task<PersonDtoViewModel> FindByFamilyAsync(string family)
        {
            var person = PersonRepository.FindByFamilyAsync(family);
            return Mapper.Map<PersonAggregate,PersonDtoViewModel>(await person);
        }

        public async Task<PersonDtoViewModel> FindByNationalIdAsync(int nationalId)
        {
            var person = PersonRepository.FindByNationalId(nationalId);
            return Mapper.Map<PersonAggregate, PersonDtoViewModel>(await person);
        }

        public async Task<List<PersonDtoViewModel>> FindByTagNameAsync(string tagName)
        {
            var person = PersonRepository.FindByTagName(tagName);
            return Mapper.Map<List<PersonAggregate>,List<PersonDtoViewModel>>(await person);
        }
        
    }
}
