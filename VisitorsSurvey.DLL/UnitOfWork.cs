using VisitorsSurvey.DLL.Data;
using VisitorsSurvey.DLL.Entities;
using VisitorsSurvey.DLL.IRepository;
using VisitorsSurvey.DLL.Repository;

namespace VisitorsSurvey.DLL
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructor

        private AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }


        #endregion Constructor

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
                return;

            if (this._context == null)
                return;

            this._context.Dispose();
            this._context = null;
        }

        public int Commit()
        {
            var saveResult = _context.SaveChanges();

            return saveResult;
        }

        public IGenericRepository<Park, int> ParkRepository => new GenericRepository<Park, int>(_context);
        public IVisitorReviewRepository VisitorReviewRepository => new VisitorReviewRepository(_context);
        public IGenericRepository<City, int> CityRepository => new GenericRepository<City, int>(_context);
        public IGenericRepository<Governate, int> GovernateRepository => new GenericRepository<Governate, int>(_context);
        public IGenericRepository<Region, int> RegionRepository => new GenericRepository<Region, int>(_context);
        public IGenericRepository<WeekDay, int> WeekDayRepository => new GenericRepository<WeekDay, int>(_context);
        public IGenericRepository<YearMonth, int> YearMonthRepository => new GenericRepository<YearMonth, int>(_context);
        public IGenericRepository<VisitorReviewItem, int> VisitorReviewItemRepository => new GenericRepository<VisitorReviewItem, int>(_context);
        public IGenericRepository<Rate, int> RateRepository => new GenericRepository<Rate, int>(_context);


    }
}
