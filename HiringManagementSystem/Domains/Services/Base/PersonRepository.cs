using HiringManagementSystem.Domains.DomainModels.Aggregates;
using HiringManagementSystem.Domains.Repositories.Base;
using HiringManagementSystem.Domains.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
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

        public Task<PersonAggregate> FindByNationalId(int nationalId)
        {
            return DbSet.FirstOrDefaultAsync(p => p.NationalId == nationalId);
        }

        public async Task<PersonAggregate> FindByTagName(string tagName)
        {
            var person = DbSet.Single(p => p.Tags.Any(t => t.TagName == tagName));
            return person;
        }
    }
}
