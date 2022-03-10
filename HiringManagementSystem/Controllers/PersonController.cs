using HiringManagementSystem.Domains.ViewModels.Abstarct;
using HiringManagementSystem.Domains.ViewModels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController(IPersonAppService personAppService)
        {
            PersonAppService = personAppService;
        }

        public IPersonAppService PersonAppService { get; }


        public async Task<List<PersonDtoViewModel>> GetAllAsync()
        {
            var persons = await PersonAppService.GetAllAsync();
            return persons;
        }

        public async Task<PersonDtoViewModel> FindByIdAsync(int id)
        {
            var person = await PersonAppService.FindByIdAsync(id);
            return person;
        }

        public async Task InsertAsync(PersonDtoViewModel person)
        {
            await PersonAppService.InsertAsync(person);
        }

        public async Task UpdateAsync(PersonDtoViewModel person)
        {
            await PersonAppService.UpdateAsync(person);
        }

        public async Task DeleteAsync(int id)
        {
            await PersonAppService.DeleteAsync(id);
        }

        Task<PersonDtoViewModel> FindByFamilyAsync(string family)
        {
            PersonAppService.find
        }
        Task<PersonDtoViewModel> FindByNationalId(int nationalId)
        {

        }
        PersonAggregate FindByTagName(string name);

    }
}
