using VisitorsSurvey.DLL.Entities;
using VisitorsSurvey.DLL.IRepository;

namespace VisitorsSurvey.DLL
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        public IGenericRepository<Park, int> ParkRepository { get; }
        public IGenericRepository<Governate, int> GovernateRepository { get; }
        public IGenericRepository<City, int> CityRepository { get; }
        public IGenericRepository<Region, int> RegionRepository { get; }
        public IGenericRepository<WeekDay, int> WeekDayRepository { get; }
        public IGenericRepository<YearMonth, int> YearMonthRepository { get; }
        public IGenericRepository<VisitorReviewItem, int> VisitorReviewItemRepository { get; }
        public IGenericRepository<Rate, int> RateRepository { get; }
        public IVisitorReviewRepository VisitorReviewRepository { get; }

    }
}
