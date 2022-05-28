using Microsoft.AspNetCore.Identity;

namespace WebApp.Data.Repository.IRepository
{
    public interface IUserRepository: IRepository<IdentityUser>
    {
    }
}
