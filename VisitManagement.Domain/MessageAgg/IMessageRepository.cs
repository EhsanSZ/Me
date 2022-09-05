using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Message;

namespace VisitManagement.Domain.MessageAgg
{
    public interface IMessageRepository
    {
        void Add(Message message);
        void Remove(Message message);
        void Save();
        List<MessageViewModel> GetMessages(MessageSearchModel search);
        Message GetMessageBy(int id);
        MessageDetailViewModel GetMessageDetailBy(int id);
    }
}
