using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokenBasedAuthentication.Data
{
    public class SeedDataBase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "kasunysoft@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "Kasunjith"
                };
                userManager.CreateAsync(user, "Kasunysoft123@");
            }
        }
    }
}
