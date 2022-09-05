using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Message;
using VisitManagement.Domain.MessageAgg;

namespace VisitManagement.Infrastructure.EFCore.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly VisitContext _context;
        public MessageRepository(VisitContext context)
        {
            _context = context;
        }

        public void Add(Message message)
        {
            _context.Messages.Add(message);
        }

        public Message GetMessageBy(int id)
        {
           return _context.Messages.FirstOrDefault(x=> x.ID == id);
        }

        public MessageDetailViewModel GetMessageDetailBy(int id)
        {
            var messages = _context.Messages.FirstOrDefault(x => x.ID == id);
            return new MessageDetailViewModel()
            {
                ID = messages.ID ,
                Brand = messages.Brand ,
                Date = messages.Date ,
                FamilyOS = messages.FamilyOS ,
                IP = messages.IP ,
                Name = messages.Name ,
                FamilyDevice  = messages.FamilyDevice ,
                Model = messages.Model ,
                Text = messages.Text ,
                Version = messages.Version ,
                VisitID = messages.VisitID
            };
        }

        public List<MessageViewModel> GetMessages(MessageSearchModel search)
        {
            throw new NotImplementedException();
        }

        public void Remove(Message message)
        {
            _context.Messages.Remove(message);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
