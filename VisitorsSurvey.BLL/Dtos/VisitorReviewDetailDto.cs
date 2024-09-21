namespace VisitorsSurvey.DLL.Entities
{
    public class VisitorReviewDetailDto
    {
        public int VisitorReviewDetailCode { get; set; }
        public int VisitorItemCode { get; set; }
        public int RateCode { get; set; }

        public int VisitorReviewCode { get; set; }
        public VisitorReviewDto VisitorReviewNavigation { get; set; }
    }
}
