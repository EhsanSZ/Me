using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Visitor;
using VisitManagement.Domain.VisitorAgg;

namespace VisitManagement.Application
{
    public class VisitorApplication : IVisitorApplication
    {
        private readonly IVisitorRepository _visitorRepository;
        public VisitorApplication(IVisitorRepository visitorRepository)
        {
            _visitorRepository = visitorRepository;
        }
        public void Execute(CreateVisitor request)
        {
            var visitor = new Visitor(request.Ip, request.ReferrerLink, request.FamilyOS, request.Version,
               request.Brand, request.FamilyDevice, request.Model, request.IsSpider,request.VisitID);
            _visitorRepository.Create(visitor);
        }

        public List<VisitorViewModel> GetVisitors(VisitorSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
