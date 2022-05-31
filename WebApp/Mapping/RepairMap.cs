using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class RepairMap : ClassMapping<Repair>
    {
        public RepairMap()
        {
            Schema("dbo");
            Table("Repair");

            Id(x => x.Id, m => { m.Generator(Generators.Guid); });

            Property(x => x.ReportDate);
            Property(x => x.PickupDate);
            Property(x => x.DeviceModel);
            Property(x => x.Describe);
            Property(x => x.Warranty);
            Property(x => x.Tracking);

            ManyToOne(x => x.Mark, m =>
            {
                m.Column("MarkId");
            });

            ManyToOne(x => x.Status, m =>
            {
                m.Column("StatusId");
            });

            ManyToOne(x => x.RepairCost, m =>
            {
                m.Column("RepairCostId");
            });

            ManyToOne(x => x.Address, m =>
            {
                m.Column("AddressId");
            });

            ManyToOne(x => x.DeviceType, m =>
            {
                m.Column("DeviceTypeId");
            });

            ManyToOne(x => x.IdentityUser, m =>
            {
                m.Column("UserId");
            });
        }
    }
}