using HiringManagementSystem.Models.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Models.Repositories.Base
{
    public class BaseRepository<K_DbContext, T_Entity, U_PrimaryKey> : IRepository<T_Entity, U_PrimaryKey>
        where T_Entity : class where K_DbContext : HiringManagementSystemDbContext
    {

        #region [- Ctor -]
        public BaseRepository(K_DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = dbContext.Set<T_Entity>();

        }
        #endregion

        #region [- Props -]
        public virtual K_DbContext DbContext { get; set; }
        public virtual DbSet<T_Entity> DbSet { get; set; }
        #endregion

        #region [- DeleteAsync(T_Entity entity) -]
        public virtual async Task DeleteAsync(T_Entity entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
            await SaveChanges();
        }
        #endregion

        #region [- DeleteAsync(U_PrimaryKey id) -]
        public virtual async Task DeleteAsync(U_PrimaryKey id)
        {
            var entity = DbSet.Find(id);
            DbSet.Remove(entity);
            await SaveChanges();
        }
        #endregion

        #region [- FindById(U_PrimaryKey id) -]
        public virtual async Task<T_Entity> FindById(U_PrimaryKey id)
        {
            var entity = DbSet.FindAsync(id);
            return await entity;
        }
        #endregion

        #region [- GetAllAsync() -]
        public virtual async Task<List<T_Entity>> GetAllAsync()
        {
            var entities = DbSet.AsNoTracking().ToListAsync();
            return await entities;
        }
        #endregion

        #region [- InsertAsync(T_Entity entity) -]
        public virtual async Task InsertAsync(T_Entity entity)
        {
            using (DbContext)
            {
                DbSet.Add(entity);
                await SaveChanges();
            }
        } 
        #endregion

        public async Task SaveChanges()
        {
            await DbContext.SaveChangesAsync();
        }

        #region [- UpdateAsync(T_Entity entity) -]
        public virtual async Task UpdateAsync(T_Entity entity)
        {
            using (DbContext)
            {
                DbSet.Update(entity);
                await SaveChanges();
            }
        } 
        #endregion
    }
}
