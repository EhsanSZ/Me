using _0_Framework.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Visitor;
using VisitManagement.Domain.VisitorAgg;

namespace VisitManagement.Infrastructure.EFCore.Repository
{
    public class VisitorRepository :RepositoryBase<int, Visitor> , IVisitorRepository
    {
        private readonly VisitContext _context;
        public VisitorRepository(VisitContext context):base(context)
        {
            _context = context;
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
