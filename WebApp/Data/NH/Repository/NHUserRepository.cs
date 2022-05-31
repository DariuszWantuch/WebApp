using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.NH.Repository.IRepository;

namespace WebApp.Data.NH.Repository
{
    public class NHUserRepository : NHRepository<IdentityUser>, INHUserRepository
    {
    }
}
