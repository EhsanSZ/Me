using VisitManagement.ApplicationContracts.Visitor;

namespace VisitManagement.ApplicationContracts.Message
{
    public class SendMessage : CreateVisitor
    {
        public string Name { get; set; }
        public string Text { get; set; } 
    }
}
