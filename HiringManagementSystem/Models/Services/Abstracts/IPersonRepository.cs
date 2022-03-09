using HiringManagementSystem.Models.DomainModels.Aggregates;
using HiringManagementSystem.Models.Repositories.Abstracts;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace HiringManagementSystem.Models.Services.Abstracts
{
    [ScopedService]
    public interface IPersonRepository : IRepository<PersonAggregate,int>
    {
        Task<PersonAggregate> FindByFamilyAsync(string family);
        Task<PersonAggregate> FindByNationalId(int nationalId);
        PersonAggregate FindByTagName(string name);
    }
}
