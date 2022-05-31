using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class StatusMap : ClassMapping<Status>
    {
        public StatusMap()
        {
            Schema("dbo");
            Table("Status");

            Id(x => x.Id, m => { m.Generator(Generators.Identity); });

            Property(x => x.RepairStatus);
        }
    }
}