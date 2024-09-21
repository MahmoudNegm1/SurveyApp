using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.DLL.IRepository
{
    public interface IVisitorReviewRepository
    {
        int Add(VisitorReview entity);
        void AddDetailRange(List<VisitorReviewDetail> entity);
        List<VisitorReview> GetList();
    }
}
