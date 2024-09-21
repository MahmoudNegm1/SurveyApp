namespace VisitorsSurvey.DLL.Entities
{
    public class CustomPrepareForSave
    {
        public List<WeekDayDto> WeekDays { get; set; }
        public List<YearMonthDto> YearMonths { get; set; }
        public List<RateDto> Rates { get; set; }
        public List<VisitorReviewItemDto> VisitorReviewItems { get; set; }
        public List<string> MonthDays { get; set; }
        public int Year { get; set; }
    }


    public class CustomPrepareForPost
    {
        public int RegionCode { get; set; }
        public int CityCode { get; set; }
        public int GovernateCode { get; set; }
        public int? ParkCode { get; set; }
        public int WeekDayCode { get; set; }
        public int MonthDayCode { get; set; }
        public int YearMonthCode { get; set; }
        public string Notes { get; set; } = string.Empty;
        public List<SelectedRateFields> SelectedRates { get; set; }

    }
    public class SelectedRateFields
    {

        public int VisitorReviewItemCode { get; set; }
        public int RateCode { get; set; }
    }
}
