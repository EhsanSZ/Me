

namespace VisitManagement.ApplicationContracts.Visitor
{
    public class CreateVisitor
    {
        public string Ip { get; set; }
        public string ReferrerLink { get; set; }
        public string FamilyOS { get; set; }
        public string Version { get; set; }
        public string Brand { get; set; }
        public string FamilyDevice { get; set; }
        public string Model { get; set; }
        public bool IsSpider { get; set; }
        public string VisitID { get; set; }
        
    }
}
