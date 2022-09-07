using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Message;

namespace VisitManagement.Domain.MessageAgg
{
    public interface IMessageRepository : IRepository<int,Message>
    {
        List<MessageViewModel> GetMessages(MessageSearchModel search);
        MessageDetailViewModel GetMessageDetailBy(int id);
    }
}
