using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.ApplicationContracts.Visitor
{
    public interface IVisitorApplication
    {
        void Execute(CreateVisitor request);
        List<VisitorViewModel> GetVisitors(VisitorSearchModel searchModel);
    }
}
