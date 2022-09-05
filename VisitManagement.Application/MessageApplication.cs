using System.Collections.Generic;
using VisitManagement.ApplicationContracts.Message;
using VisitManagement.Domain.MessageAgg;

namespace VisitManagement.Application
{
    public class MessageApplication : IMessageApplication
    {
        private readonly IMessageRepository _messageRepository;
        public MessageApplication(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public List<MessageViewModel> GetMessages(MessageSearchModel search)
        {
            return _messageRepository.GetMessages(search);
        }

        public MessageDetailViewModel GetMessageBy(int id)
        {
            return _messageRepository.GetMessageDetailBy(id);      
        }

        public void SendMessage(SendMessage command)
        {
            command.VisitID = "" ;// ""
            var message = new Message(command.Name, command.Text, command.Ip, command.FamilyOS
                , command.Version, command.Brand, command.FamilyDevice, command.Model, command.VisitID);

            _messageRepository.Add(message);
            _messageRepository.Save(); 
        }

        public void RemoveMessage(int id)
        {
            var message = _messageRepository.GetMessageBy(id);
            _messageRepository.Remove(message);
            _messageRepository.Save();
        }

    }
}
