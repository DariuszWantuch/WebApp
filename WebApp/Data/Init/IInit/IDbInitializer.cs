using Microsoft.AspNetCore.Identity;

namespace WebApp.Data.Init.IInit
{
    public interface IDbInitializer
    {
        void Initialize(UserManager<IdentityUser> userManager);
    }
}
