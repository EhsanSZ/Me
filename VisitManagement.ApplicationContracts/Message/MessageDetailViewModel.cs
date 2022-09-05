using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.ApplicationContracts.Message
{
    public class MessageDetailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string IP { get; set; }
        public string FamilyOS { get; set; }
        public string Version { get; set; }
        public string Brand { get; set; }
        public string FamilyDevice { get; set; }
        public string Model { get; set; }
        public string VisitID { get; set; }
    }
}
