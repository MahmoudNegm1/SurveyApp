namespace VisitorsSurvey.DLL.Entities
{
    public class ParkDto
    {
        public int ParkCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int CityCode { get; set; }
        public CityDto CityNavigation { get; set; }
    }
}
