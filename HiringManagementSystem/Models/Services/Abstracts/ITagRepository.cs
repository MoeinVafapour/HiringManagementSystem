using HiringManagementSystem.Models.DomainModels.Aggregates;
using HiringManagementSystem.Models.Repositories.Abstracts;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace HiringManagementSystem.Models.Services.Abstracts
{
    [ScopedService]
    public interface ITagRepository : IRepository<TagAggregate,int>
    {
        Task<TagAggregate> FindByTagNameAsync(string tagName);
        Task<TagAggregate> FindPersonByTag(string tagName);
    }
}
