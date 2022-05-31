using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class MarkMap : ClassMapping<Mark>
    {
        public MarkMap()
        {
            Schema("dbo");
            Table("Mark");

            Id(x => x.Id, m => { m.Generator(Generators.Identity); });

            Property(x => x.MarkName);
        }
    }
}