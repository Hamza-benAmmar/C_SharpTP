using System.Linq.Expressions;

namespace TP4GestionDesStudents.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext _universityContext;

        public Repository(UniversityContext universityContext)
        {
            this._universityContext = universityContext;
        }
        public TEntity Get(int id)
        {
            return _universityContext.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _universityContext.Set<TEntity>().ToList();
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _universityContext.Set<TEntity>().Where(predicate);
        }
        public bool Add(TEntity entity)
        {
            try
            {
                _universityContext.Set<TEntity>().Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddRange(IEnumerable<TEntity> entities)
        {
            try
            {
                _universityContext.Set<TEntity>().AddRange(entities);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Remove(TEntity entity)
        {
            try
            {
                _universityContext.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            try
            {
                _universityContext.Set<TEntity>().RemoveRange(entities);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
