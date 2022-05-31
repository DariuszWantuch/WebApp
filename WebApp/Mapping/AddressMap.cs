using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class AddressMap : ClassMapping<Address>
    {
        public AddressMap()
        {
            Schema("dbo");
            Table("Address");

            Id(x => x.Id, m => { m.Generator(Generators.Identity); });

            Property(x => x.FirstName);
            Property(x => x.LastName);
            Property(x => x.PhoneNumber);
            Property(x => x.Street);
            Property(x => x.City);
            Property(x => x.PostalCode);
        }
    }
}
