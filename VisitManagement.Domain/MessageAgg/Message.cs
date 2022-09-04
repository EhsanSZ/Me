using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.Domain.MessageAgg
{
    public class Message
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }
        public string IP { get; private set; }
        public string FamilyOS { get; private set; }
        public string Version { get; private set; }
        public string Brand { get; private set; }
        public string FamilyDevice { get; private set; }
        public string Model { get; private set; }
        public string VisitID { get; private set; }

        protected Message()
        {

        }
        public Message(string name , string text , string ip, string familyOS, string version, 
            string brand,string familyDevice, string model, string visitID)
        {
            Name = name;
            Text = text;
            IP = ip;
            FamilyOS = familyOS;
            Version = version;
            Brand = brand;
            FamilyDevice = familyDevice;
            Model = model;
            Date = DateTime.Now;
            VisitID = visitID;
        }
    }

}
