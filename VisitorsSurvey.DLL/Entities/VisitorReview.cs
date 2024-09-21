namespace VisitorsSurvey.DLL.Entities
{
    public class VisitorReview
    {
        public int VisitorReviewCode { get; set; }
        public string Notes { get; set; }
        public int WeekDayName { get; set; }
        public int DayOfMonth { get; set; }
        public int Month { get; set; }
        public int RegionCode { get; set; }
        public int GovernateCode { get; set; }
        public int CityCode { get; set; }
        public int ParkCode { get; set; }
        public int Year { get; set; }
        public ICollection<VisitorReviewDetail> VisitorReviewDetail { get; set; }
    }
}
