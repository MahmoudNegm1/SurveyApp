using VisitorsSurvey.DLL.Data;
using VisitorsSurvey.DLL.Entities;
using VisitorsSurvey.DLL.IRepository;

namespace VisitorsSurvey.DLL.Repository
{
    public class VisitorReviewRepository : IVisitorReviewRepository
    {
        private readonly AppDbContext _dbContext;

        public VisitorReviewRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(VisitorReview entity)
        {
            _dbContext.VisitorReviews.Add(entity);
            _dbContext.SaveChanges();
            return entity.VisitorReviewCode;
        }

        public void AddDetailRange(List<VisitorReviewDetail> entity)
        {
            _dbContext.VisitorReviewDetails.AddRange(entity);
            _dbContext.SaveChanges();
        }
        public List<VisitorReview> GetList()
        {
            var result = _dbContext.VisitorReviews.ToList();

            return result;
        }

    }
}
