using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Repositories.Abstracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace HiringManagementSystem.Domains.Services.Abstracts
{
    [ScopedService]
    public interface ITagRepository : IRepository<TagAggregate,int>
    {
        Task<List<TagAggregate>> FindByTagNameAsync(string tagName);
    }
}
