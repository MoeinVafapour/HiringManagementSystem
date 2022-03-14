using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Repositories.Base;
using HiringManagementSystem.Domains.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.Services.Base
{
    public class PersonRepository : BaseRepository<HiringManagementSystemDbContext, PersonAggregate, int>,
                                    IPersonRepository
    {
        public PersonRepository(HiringManagementSystemDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<PersonAggregate> FindByFamilyAsync(string family)
        {
            var person = await DbSet.FirstOrDefaultAsync(p => p.Family == family);
            return person;
        }

        public async Task<PersonAggregate> FindByNationalId(int nationalId)
        {
            var person = await DbSet.FirstOrDefaultAsync(p => p.NationalId == nationalId);
            return person;
        }

        public async Task<List<PersonAggregate>> FindByTagName(string tagName)
        {
            var person = await DbSet.Where(p => p.Tags.Any(t => t.TagName == tagName)).ToListAsync();
            return person;
        }
    }
}
