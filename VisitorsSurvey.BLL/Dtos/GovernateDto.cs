namespace VisitorsSurvey.DLL.Entities
{
    public class GovernateDto
    {
        public int GovernateCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int RegionCode { get; set; }
        public RegionDto RegionNavigation { get; set; }
        public virtual List<CityDto> CitiesNavigation { get; set; }
    }
}
