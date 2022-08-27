using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Visitor;
using VisitManagement.Domain.VisitorAgg;

namespace VisitManagement.Infrastructure.EFCore.Repository
{
    public class VisitorRepository : IVisitorRepository
    {
        private readonly VisitContext _visitContext;
        public VisitorRepository(VisitContext visitContext)
        {
            _visitContext = visitContext;
        }
        public void Add(Visitor visitor)
        {
            _visitContext.Visitors.Add(visitor);
            _visitContext.SaveChanges();
        }

        public List<Visitor> GetVisitors()
        {
            throw new NotImplementedException();
        }

        public List<VisitorViewModel> GetVisitors(VisitorSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
