using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.IAppService
{
    public interface ICityAppService
    {
        List<CityDto> GetList();
    }
}
