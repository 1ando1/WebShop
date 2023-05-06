using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebShop.Constants;
using WebShop.Data;
using WebShop.Data.Entities.Identity;

public static class SeederDB
{
    public static void SeedData(this IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices
            .GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppEFContext>();
            context.Database.Migrate();

            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<UserEntity>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<RoleEntity>>();

            if (!context.Roles.Any())
            {
                RoleEntity admin = new RoleEntity()
                {
                    Name = Roles.Admin
                };

                RoleEntity user = new RoleEntity()
                {
                    Name = Roles.User
                };
                var result = roleManager.CreateAsync(admin).Result;
                result = roleManager.CreateAsync(user).Result;
            }

            if (!context.Users.Any())
            {
                UserEntity user = new UserEntity()
                {
                    FirstName = "Anton",
                    LastName = "Dobrovolskyi",
                    Email = "dobrovolskuy.anton2006@gmail.com",
                    UserName = "dobrovolskuy.anton2006@gmail.com"
                };

                var result = userManager.CreateAsync(user).Result;
                if (result.Succeeded)
                {
                    result = userManager.AddToRoleAsync(user, Roles.Admin).Result;
                }
            }
        }
    }
}