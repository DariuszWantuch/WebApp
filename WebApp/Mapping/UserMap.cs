using Microsoft.AspNetCore.Identity;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class UserMap : ClassMapping<IdentityUser>
    {
        public UserMap()
        {
            Schema("dbo");
            Table("AspNetUsers");

            Id(x => x.Id, m => { m.Generator(Generators.Identity); });

            Property(x => x.UserName);
            Property(x => x.NormalizedUserName);
            Property(x => x.Email);
            Property(x => x.NormalizedEmail);
            Property(x => x.EmailConfirmed);
            Property(x => x.PasswordHash);
            Property(x => x.SecurityStamp);
            Property(x => x.ConcurrencyStamp);
            Property(x => x.PhoneNumber);
            Property(x => x.PhoneNumberConfirmed);
            Property(x => x.TwoFactorEnabled);
            Property(x => x.LockoutEnd);
            Property(x => x.LockoutEnabled);
            Property(x => x.AccessFailedCount);
        }
    }
}