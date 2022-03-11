using HiringManagementSystem.Domains.ViewModels.Abstarct;
using HiringManagementSystem.Domains.ViewModels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Controllers
{
    [ApiController]
    public class TagController : ControllerBase
    {
        public TagController(ITagAppService tagAppService)
        {
            TagAppService = tagAppService;
        }

        public ITagAppService TagAppService { get; set; }

        [Route("wapi/v2/1")]
        [HttpGet]
        public async Task<List<TagDtoViewModel>> GetAllAsync()
        {
            var tags = await TagAppService.GetAllAsync();
            return tags;
        }

        [Route("wapi/v2/2")]
        [HttpGet]
        public async Task<TagDtoViewModel> FindByIdAsync(int id)
        {
            var tag = await TagAppService.FindByIdAsync(id);
            return tag;
        }

        [Route("wapi/v2/3")]
        [HttpPost]
        public async Task InsertAsync(TagDtoViewModel tag)
        {
            await TagAppService.InsertAsync(tag);
        }

        [Route("wapi/v2/4")]
        [HttpPut]
        public async Task UpdateAsync(TagDtoViewModel tag)
        {
            await TagAppService.UpdateAsync(tag);
        }

        [Route("wapi/v2/5")]
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await TagAppService.DeleteAsync(id);
        }

        [Route("wapi/v2/6")]
        [HttpGet]
        public async Task<List<TagDtoViewModel>> FindByTagNameAsync(string tagName)
        {
            var tag = await TagAppService.FindByTagNameAsync(tagName);
            return tag;
        }
    }
}
