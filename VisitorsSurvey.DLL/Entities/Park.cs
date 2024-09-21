namespace VisitorsSurvey.DLL.Entities
{
    public class Park
    {
        public int ParkCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int CityCode { get; set; }
        public City CityNavigation { get; set; }
    }
}
