using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class RepairCostMap : ClassMapping<RepairCost>
    {
        public RepairCostMap()
        {
            Schema("dbo");
            Table("RepairCost");

            Id(x => x.Id, m => { m.Generator(Generators.Identity); });

            Property(x => x.Cost);
            Property(x => x.FaultDescription);
            Property(x => x.IsAccepted);
            Property(x => x.IsRejected);
        }
    }
}
