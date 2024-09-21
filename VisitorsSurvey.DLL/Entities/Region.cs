namespace VisitorsSurvey.DLL.Entities
{
    public class Region
    {
        public int RegionCode { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public virtual ICollection<Governate> GovernateNavigation { get; set; }
    }
}
