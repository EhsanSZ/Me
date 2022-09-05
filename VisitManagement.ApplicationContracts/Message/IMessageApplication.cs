

using System.Collections.Generic;

namespace VisitManagement.ApplicationContracts.Message
{
    public interface IMessageApplication
    {
        List<MessageViewModel> GetMessages(MessageSearchModel search);
        MessageDetailViewModel GetMessageBy(int id);
        void SendMessage(SendMessage command);
        void RemoveMessage(int id);
    }
}
