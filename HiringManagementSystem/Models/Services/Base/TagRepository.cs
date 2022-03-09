using HiringManagementSystem.Models.DomainModels.Aggregates;
using HiringManagementSystem.Models.Repositories.Base;
using HiringManagementSystem.Models.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HiringManagementSystem.Models.Services.Base
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

        public Task<TagAggregate> FindPersonByTag(string tagName)
        {
            var model = DbSet.Include(t => t.Person).FirstOrDefaultAsync(t => t.TagName == tagName);
            return model;
        }
    }
}
