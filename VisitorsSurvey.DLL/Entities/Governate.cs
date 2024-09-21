namespace VisitorsSurvey.DLL.Entities
{
    public class Governate
    {
        public int GovernateCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int RegionCode { get; set; }
        public virtual Region RegionNavigation { get; set; }
        public virtual ICollection<City> CitiesNavigation { get; set; }
    }
}
