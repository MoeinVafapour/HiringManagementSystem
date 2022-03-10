using HiringManagementSystem.Domains.ViewModels.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.ViewModels.Abstarct
{
    public interface ITagAppService
    {
        Task<List<TagDtoViewModel>> GetAllAsync();
        Task<TagDtoViewModel> FindByIdAsync(int id);
        Task InsertAsync(TagDtoViewModel tag);
        Task UpdateAsync(TagDtoViewModel tag);
        Task DeleteAsync(int id);
    }
}
