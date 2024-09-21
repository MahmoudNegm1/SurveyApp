namespace VisitorsSurvey.DLL.Entities
{
    public class RegionDto
    {
        public int RegionCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public virtual List<GovernateDto> GovernateNavigation { get; set; }
    }
}
