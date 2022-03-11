using HiringManagementSystem.Domains.ViewModels.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace HiringManagementSystem.Domains.ViewModels.Abstarct
{
    [ScopedService]
    public interface ITagAppService
    {
        Task<List<TagDtoViewModel>> GetAllAsync();
        Task<TagDtoViewModel> FindByIdAsync(int id);
        Task InsertAsync(TagDtoViewModel tag);
        Task UpdateAsync(TagDtoViewModel tag);
        Task DeleteAsync(int id);
        Task<List<TagDtoViewModel>> FindByTagNameAsync(string tagName);
    }
}
