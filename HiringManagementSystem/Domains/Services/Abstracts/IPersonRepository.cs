using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Repositories.Abstracts;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace HiringManagementSystem.Domains.Services.Abstracts
{
    [ScopedService]
    public interface IPersonRepository : IRepository<PersonAggregate, int>
    {
        Task<PersonAggregate> FindByFamilyAsync(string family);
        Task<PersonAggregate> FindByNationalId(int nationalId);
        PersonAggregate FindByTagName(string name);
    }
}
