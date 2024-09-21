using VisitorsSurvey.DLL.Data;
using VisitorsSurvey.DLL.IRepository;

namespace VisitorsSurvey.DLL.Repository
{
    public class GenericRepository<T, TId> : IGenericRepository<T, TId> where T : class
    {
        protected readonly AppDbContext context;

        public GenericRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }
        public virtual void Edit(TId id, T entity)
        {
            var dbEntity = GetById(id);
            context.Entry(dbEntity).CurrentValues.SetValues(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }



        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public IQueryable<T> GetAllQueryable()
        {
            return context.Set<T>().AsQueryable();
        }

        public T GetById(TId id)
        {
            return context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

    }
}
