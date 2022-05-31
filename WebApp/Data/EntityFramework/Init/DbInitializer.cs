using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.Init.IInit;
using WebApp.Utility;

namespace WebApp.Data.Init
{
    public class DbInitializer : IDbInitializer
    {
        public void Initialize(UserManager<IdentityUser> userManager)
        {
            userManager.CreateAsync(new IdentityUser
            {
                UserName = "user@user.pl",
                Email = "user@user.pl",
                EmailConfirmed = true,
            }, "User1234!").GetAwaiter().GetResult();

            userManager.CreateAsync(new IdentityUser
            {
                UserName = "maciek@wp.pl",
                Email = "maciek@wp.pl",
                EmailConfirmed = true,
            }, "User1234!").GetAwaiter().GetResult();

            userManager.CreateAsync(new IdentityUser
            {
                UserName = "karol@wp.pl",
                Email = "karol@wp.pl",
                EmailConfirmed = true,
            }, "User1234!").GetAwaiter().GetResult();

            userManager.CreateAsync(new IdentityUser
            {
                UserName = "kaja@wp.pl",
                Email = "kaja@wp.pl",
                EmailConfirmed = true,
            }, "User1234!").GetAwaiter().GetResult();

            userManager.CreateAsync(new IdentityUser
            {
                UserName = "kacper@wp.pl",
                Email = "kacper@wp.pl",
                EmailConfirmed = true,
            }, "User1234!").GetAwaiter().GetResult();
        }
    }
}
