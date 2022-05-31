using Microsoft.AspNetCore.Identity;

namespace WebApp.Data.EntityFramework.Repository.IRepository
{
    public interface IEFUserRepository: IEFRepository<IdentityUser>
    {
    }
}
