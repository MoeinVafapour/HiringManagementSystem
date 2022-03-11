using HiringManagementSystem.Domains.ViewModels.Abstarct;
using HiringManagementSystem.Domains.ViewModels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Controllers
{
    
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController(IPersonAppService personAppService)
        {
            PersonAppService = personAppService;
        }

        public IPersonAppService PersonAppService { get; set; }

        [Route("wapi/v1/1")]
        [HttpGet]
        public async Task<List<PersonDtoViewModel>> GetAllAsync()
        {
            var persons = await PersonAppService.GetAllAsync();
            return persons;
        }
        [Route("wapi/v1/2")]
        [HttpGet]
        public async Task<PersonDtoViewModel> FindByIdAsync(int id)
        {
            var person = await PersonAppService.FindByIdAsync(id);
            return person;
        }

        [Route("wapi/v1/3")]
        [HttpPost]
        public async Task InsertAsync(PersonDtoViewModel person)
        {
            await PersonAppService.InsertAsync(person);
        }

        [Route("wapi/v1/4")]
        [HttpPut]
        public async Task UpdateAsync(PersonDtoViewModel person)
        {
            await PersonAppService.UpdateAsync(person);
        }

        [Route("wapi/v1/5")]
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await PersonAppService.DeleteAsync(id);
        }

        [Route("wapi/v1/6")]
        [HttpGet]
        public async Task<PersonDtoViewModel> FindByFamilyAsync(string family)
        {
            var person = await PersonAppService.FindByFamilyAsync(family);
            return person;
        }

        [Route("wapi/v1/7")]
        [HttpGet]
        public Task<PersonDtoViewModel> FindByNationalId(int nationalId)
        {
            var person = PersonAppService.FindByNationalIdAsync(nationalId);
            return person;
        }

        [Route("wapi/v1/8")]
        [HttpGet]
        public Task<PersonDtoViewModel> FindByTagName(string tagName)
        {
            var person = PersonAppService.FindByTagNameAsync(tagName);
            return person;
        }

    }
}
