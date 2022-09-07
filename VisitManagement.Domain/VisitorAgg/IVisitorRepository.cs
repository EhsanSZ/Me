using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Visitor;

namespace VisitManagement.Domain.VisitorAgg
{
    public interface IVisitorRepository : IRepository<int,Visitor>
    {
        List<Visitor> GetVisitors();
        List<VisitorViewModel> GetVisitors(VisitorSearchModel searchModel);
    }
}
