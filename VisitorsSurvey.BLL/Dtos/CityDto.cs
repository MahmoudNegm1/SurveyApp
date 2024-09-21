namespace VisitorsSurvey.DLL.Entities
{
    public class CityDto
    {
        public int CityCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int GovernateCode { get; set; }
        public virtual GovernateDto GovernateNavigation { get; set; }
        public virtual List<ParkDto> ParkNavigation { get; set; }
    }
}
