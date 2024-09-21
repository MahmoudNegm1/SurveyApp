using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.IAppService
{
    public interface IVisitorReviewAppService
    {
        // List<SelectListItem> GetList();
        CustomPrepareForSave GetSave();
        void SaveReviews(CustomPrepareForPost model);
        List<VisitorReviewDto> GetList();
    }
}
