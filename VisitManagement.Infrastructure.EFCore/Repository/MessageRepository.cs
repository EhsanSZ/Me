using _0_Framework.Infrustructure;
using System.Collections.Generic;
using System.Linq;
using VisitManagement.ApplicationContracts.Message;
using VisitManagement.Domain.MessageAgg;

namespace VisitManagement.Infrastructure.EFCore.Repository
{
    public class MessageRepository : RepositoryBase<int , Message> , IMessageRepository
    {
        private readonly VisitContext _context;
        public MessageRepository(VisitContext context):base(context)
        {
            _context = context;
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
            var query = _context.Messages.Select(x => new MessageViewModel
            {
                ID = x.ID ,
                Date = x.Date ,
                FamilyDevice = x.FamilyDevice ,
                FamilyOS = x.FamilyOS ,
                Ip = x.IP ,
                Name = x.Name ,
                VisitID = x.VisitID
            });

            if (!string.IsNullOrWhiteSpace(search.VisitID))
                query.Where(x => x.VisitID.Contains(search.VisitID));
            
            if (!string.IsNullOrWhiteSpace(search.Name))
                query.Where(x => x.Name.Contains(search.Name));

            if (!string.IsNullOrWhiteSpace(search.Ip))
                query.Where(x => x.Ip.Contains(search.Ip));

            if (!string.IsNullOrWhiteSpace(search.FamilyDevice))
                query.Where(x => x.FamilyDevice.Contains(search.FamilyDevice));

            if (!string.IsNullOrWhiteSpace(search.FamilyOS))
                query.Where(x => x.FamilyOS.Contains(search.FamilyOS));

            return query.OrderByDescending(x=> x.ID).ToList();

        }

    }
}
