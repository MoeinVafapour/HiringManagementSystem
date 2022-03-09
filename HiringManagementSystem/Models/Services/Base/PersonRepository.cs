using HiringManagementSystem.Models.DomainModels.Aggregates;
using HiringManagementSystem.Models.Repositories.Base;
using HiringManagementSystem.Models.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HiringManagementSystem.Models.Services.Base
{
    public class PersonRepository : BaseRepository<HiringManagementSystemDbContext, PersonAggregate, int>,
                                    IPersonRepository
    {
        public PersonRepository(HiringManagementSystemDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<PersonAggregate> FindByFamilyAsync(string family)
        {
            return await DbSet.FirstOrDefaultAsync(p => p.Family == family);
        }

        public Task<PersonAggregate> FindByNationalId(int nationalId)
        {
            return DbSet.FirstOrDefaultAsync(p => p.NationalId == nationalId);
        }

        public PersonAggregate FindByTagName(string name)
        {
            var person = DbContext.Person.Where(p => p.Tags.Select(t => t.TagName == name).FirstOrDefault()).FirstOrDefault();
            return person;
        }

    }
}
