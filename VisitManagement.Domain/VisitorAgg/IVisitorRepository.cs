using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.ApplicationContracts.Visitor;

namespace VisitManagement.Domain.VisitorAgg
{
    public interface IVisitorRepository
    {
        void Add(Visitor visitor);
        List<Visitor> GetVisitors();
        List<VisitorViewModel> GetVisitors(VisitorSearchModel searchModel);
    }
}
