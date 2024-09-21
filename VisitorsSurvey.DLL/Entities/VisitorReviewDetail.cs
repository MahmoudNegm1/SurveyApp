namespace VisitorsSurvey.DLL.Entities
{
    public class VisitorReviewDetail
    {
        public int VisitorReviewDetailCode { get; set; }
        public int VisitorItemCode { get; set; }
        public int RateCode { get; set; }

        public int VisitorReviewCode { get; set; }
        public VisitorReview VisitorReviewNavigation { get; set; }
    }
}
