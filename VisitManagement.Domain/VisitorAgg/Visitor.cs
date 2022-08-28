using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.Domain.VisitorAgg
{
    public class Visitor
    {
        public int ID { get; private set; }
        public DateTime Date { get; private set; }
        public string IP { get; private set; }
        public string ReferrerLink { get; private set; }
        public string FamilyOS { get; private set; }
        public string Version { get; private set; }
        public string Brand { get; private set; }
        public string FamilyDevice { get; private set; }
        public string Model { get; private set; }
        public bool IsSpider { get; private set; }
        public string VisitID { get; private set; }

        protected Visitor()
        {
                    
        }


        public Visitor(string ip, string referrerLink, string familyOS, string version, string brand ,
          string familyDevice, string model, bool isSpider , string visitID)
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
            VisitID = visitID;
        }

    }

}
