using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Repositories.Base;
using HiringManagementSystem.Domains.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.Services.Base
{
    public class TagRepository : BaseRepository<HiringManagementSystemDbContext, TagAggregate, int>,
                                    ITagRepository
    {
        public TagRepository(HiringManagementSystemDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<TagAggregate>> FindByTagNameAsync(string tagName)
        {
            //return  DbSet.Select(t => t.TagName == tagName).ToListAsync();
            var tags = await DbSet.AsNoTracking().Where(t => t.TagName == tagName).ToListAsync();
            return tags;
        }
    
    }
}