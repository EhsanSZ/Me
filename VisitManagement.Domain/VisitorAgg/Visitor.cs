using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.Domain.VisitorAgg
{
    public class Visitor
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string IP { get; set; }
        public string ReferrerLink { get; set; }
        public string FamilyOS { get; set; }
        public string Version { get; set; }
        public string Brand { get; set; }
        public string FamilyDevice { get; set; }
        public string Model { get; set; }
        public bool IsSpider { get; set; }

        public Visitor(string ip, string referrerLink, string familyOS, string version, string brand ,
          string familyDevice, string model, bool isSpider = false)
        {
            IP = ip;
            ReferrerLink = referrerLink;
            FamilyOS = familyOS;
            Version = version;
            Brand = brand;
            FamilyDevice = familyDevice;
            Model = model;
            IsSpider = isSpider;
            Date = DateTime.Now;
        }

    }

}
