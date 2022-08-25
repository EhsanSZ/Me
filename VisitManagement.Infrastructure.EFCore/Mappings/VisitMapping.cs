using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitManagement.Domain.VisitAgg;

namespace VisitManagement.Infrastructure.EFCore.Mappings
{
    public class VisitMapping : IEntityTypeConfiguration<Visit>
    {
        public void Configure (EntityTypeBuilder<Visit> builder)
        {

        }
    }
}
