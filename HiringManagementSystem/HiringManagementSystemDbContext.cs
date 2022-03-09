using HiringManagementSystem.Models.DomainModels.Aggregates;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HiringManagementSystem
{
    public class HiringManagementSystemDbContext : DbContext
    {
        #region [- Ctor -]
        public HiringManagementSystemDbContext(DbContextOptions<HiringManagementSystemDbContext> contextOptions)
            : base(contextOptions)
        {

        }
        #endregion

        #region [- DbSets -]
        public DbSet<PersonAggregate> Person { get; set; }
        public DbSet<TagAggregate> Tag { get; set; }
        #endregion

        #region [- OnModelCreating(ModelBuilder modelBuilder) -]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        } 
        #endregion
    }
}
