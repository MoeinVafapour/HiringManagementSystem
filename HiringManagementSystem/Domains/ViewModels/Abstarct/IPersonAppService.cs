using HiringManagementSystem.Domains.ViewModels.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.ViewModels.Abstarct
{
    public interface IPersonAppService
    {
        Task<List<PersonDtoViewModel>> GetAllAsync();
        Task<PersonDtoViewModel> FindByIdAsync(int id);
        Task InsertAsync(PersonDtoViewModel person);
        Task UpdateAsync(PersonDtoViewModel person);
        Task DeleteAsync(int id);
    }
}
