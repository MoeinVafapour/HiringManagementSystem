using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiringManagementSystem.Domains.Repositories.Abstracts
{
    public interface IRepository<T_Entity, U_PrimaryKey> where T_Entity : class
    {
        Task InsertAsync(T_Entity entity);
        Task UpdateAsync(T_Entity entity);
        Task DeleteAsync(T_Entity entity);
        Task DeleteAsync(U_PrimaryKey id);
        Task<List<T_Entity>> GetAllAsync();
        Task<T_Entity> FindByIdAsync(U_PrimaryKey id);
        Task SaveChanges();
    }
}
