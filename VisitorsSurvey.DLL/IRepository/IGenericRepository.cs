namespace VisitorsSurvey.DLL.IRepository
{
    public interface IGenericRepository<T, TId> where T : class
    {
        T GetById(TId id);
        IEnumerable<T> GetAll();
        IQueryable<T> GetAllQueryable();
        void Add(T entity);
        void Edit(TId id, T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);

    }

}
