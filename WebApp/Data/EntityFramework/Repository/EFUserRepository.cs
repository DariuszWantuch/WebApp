using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.EntityFramework.Repository.IRepository;

namespace WebApp.Data.EntityFramework.Repository
{
    public class EFUserRepository : EFRepository<IdentityUser>, IEFUserRepository
    {
        private ApplicationDbContext _db;

        public EFUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
