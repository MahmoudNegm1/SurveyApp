using AutoMapper;
using VisitorsSurvey.BLL.IAppService;
using VisitorsSurvey.DLL;
using VisitorsSurvey.DLL.Entities;

namespace VisitorsSurvey.BLL.AppService
{
    public class VisitorReviewAppService : IVisitorReviewAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public VisitorReviewAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public List<VisitorReviewDto> GetList()
        {
            var entities = _unitOfWork.VisitorReviewRepository.GetList();
            var dto = _mapper.Map<List<VisitorReviewDto>>(entities);
            return dto;
        }

        public CustomPrepareForSave GetSave()
        {
            CustomPrepareForSave customPrepareForSave = new CustomPrepareForSave();
            var weekdays = _mapper.Map<List<WeekDayDto>>(_unitOfWork.WeekDayRepository.GetAll());
            var yearMonths = _mapper.Map<List<YearMonthDto>>(_unitOfWork.YearMonthRepository.GetAll());
            List<string> daysArr = new List<string>(){
    "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
    "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
    "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"
};
            var items = _mapper.Map<List<VisitorReviewItemDto>>(_unitOfWork.VisitorReviewItemRepository.GetAll());
            var rates = _mapper.Map<List<RateDto>>(_unitOfWork.RateRepository.GetAll());
            string currentYear = DateTime.Now.Year.ToString();
            char[] yearDigits = currentYear.ToCharArray();

            string lastTwoDigits = new string(yearDigits.Skip(2).ToArray());

            customPrepareForSave.WeekDays = weekdays;
            customPrepareForSave.YearMonths = yearMonths;
            customPrepareForSave.VisitorReviewItems = items;
            customPrepareForSave.Rates = rates;
            customPrepareForSave.MonthDays = daysArr;
            customPrepareForSave.Year = int.Parse(lastTwoDigits);
            return customPrepareForSave;
        }

        public void SaveReviews(CustomPrepareForPost model)
        {
            try
            {
                VisitorReview entity = new VisitorReview();
                entity.RegionCode = model.RegionCode;
                entity.CityCode = model.CityCode;
                entity.ParkCode = model.ParkCode.GetValueOrDefault();
                entity.GovernateCode = model.GovernateCode;
                entity.DayOfMonth = model.MonthDayCode;
                entity.WeekDayName = model.WeekDayCode;
                entity.Month = model.YearMonthCode;
                entity.Notes = model.Notes;

                var response = _unitOfWork.VisitorReviewRepository.Add(entity);

                List<VisitorReviewDetail> entityDetail = new List<VisitorReviewDetail>();
                foreach (var rate in model.SelectedRates)
                {
                    var detailItem = new VisitorReviewDetail
                    {
                        VisitorItemCode = rate.VisitorReviewItemCode,
                        RateCode = rate.RateCode,
                        VisitorReviewCode = response
                    };

                    entityDetail.Add(detailItem);
                }

                _unitOfWork.VisitorReviewRepository.AddDetailRange(entityDetail);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
