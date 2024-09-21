namespace VisitorsSurvey.DLL.Entities
{
    public class City
    {
        public int CityCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int GovernateCode { get; set; }
        public virtual Governate GovernateNavigation { get; set; }
        public virtual ICollection<Park> ParkNavigation { get; set; }
    }
}
