using AutoMapper;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Park, ParkDto>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Governate, GovernateDto>().ReverseMap();
            CreateMap<VisitorReview, VisitorReviewDto>().ReverseMap();
            CreateMap<VisitorReviewItem, VisitorReviewItemDto>().ReverseMap();
            CreateMap<WeekDay, WeekDayDto>().ReverseMap();
            CreateMap<YearMonth, YearMonthDto>().ReverseMap();
            CreateMap<VisitorReviewDetail, VisitorReviewDetailDto>().ReverseMap();
            CreateMap<Rate, RateDto>().ReverseMap();

        }
    }
}
