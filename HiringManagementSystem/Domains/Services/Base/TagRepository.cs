using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Repositories.Base;
using HiringManagementSystem.Domains.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.Services.Base
{
    public class TagRepository : BaseRepository<HiringManagementSystemDbContext, TagAggregate, int>,
                                    ITagRepository
    {
        public TagRepository(HiringManagementSystemDbContext dbContext) : base(dbContext)
        {

        }

        public Task<TagAggregate> FindByTagNameAsync(string tagName)
        {
            return DbSet.FirstOrDefaultAsync(t => t.TagName == tagName);
        }
    
    }
}