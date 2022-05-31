using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class DeviceTypeMap : ClassMapping<DeviceType>
    {
        public DeviceTypeMap()
        {
            Schema("dbo");
            Table("DeviceType");

            Id(x => x.Id, m => { m.Generator(Generators.Identity); });

            Property(x => x.DeviceName);
            Property(x => x.TransportCost);
        }
    }
}