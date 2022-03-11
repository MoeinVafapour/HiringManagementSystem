using HiringManagementSystem.Domains.ViewModels.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace HiringManagementSystem.Domains.ViewModels.Abstarct
{
    [ScopedService]
    public interface IPersonAppService
    {
        Task<List<PersonDtoViewModel>> GetAllAsync();
        Task<PersonDtoViewModel> FindByIdAsync(int id);
        Task InsertAsync(PersonDtoViewModel person);
        Task UpdateAsync(PersonDtoViewModel person);
        Task DeleteAsync(int id);
        Task<PersonDtoViewModel> FindByFamilyAsync(string family);
        Task<PersonDtoViewModel> FindByNationalIdAsync(int nationalId);
        Task<PersonDtoViewModel> FindByTagNameAsync(string tagName);

    }
}
