using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseClass
    {

        private readonly DataContext _dataContext;

        public GenericRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task Create(TEntity entity)
        {
            await _dataContext.Set<TEntity>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _dataContext.Set<TEntity>().Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dataContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dataContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task Update(int id, TEntity entity)
        {
            _dataContext.Set<TEntity>().Update(entity);
            await _dataContext.SaveChangesAsync();
        }
    }
}
