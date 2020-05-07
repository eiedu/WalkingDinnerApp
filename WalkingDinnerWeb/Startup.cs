using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;
using WalkingDinnerWeb.Models;

[assembly: OwinStartupAttribute(typeof(WalkingDinnerWeb.Startup))]

namespace WalkingDinnerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Administrator"))
            {
                var role = new IdentityRole("Administrator");
                roleManager.Create(role);
                try
                {
                    var user = userManager.FindByEmail("Admin@itvitae.nl");
                    userManager.AddToRole(user.Id, "Administrator");
                }
                catch (Exception)
                {
                    var user = new ApplicationUser();
                    user.UserName = "Admin@itvitae.nl";
                    user.Email = "Admin@itvitae.nl";
                    string pwd = "Administrator.123";
                    var checkUser = userManager.Create(user, pwd);
                    if (checkUser.Succeeded)
                    {
                        userManager.AddToRole(user.Id, "Administrator");
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            if (!roleManager.RoleExists("User"))
            {
                var role = new IdentityRole("User");
                roleManager.Create(role);
            }
        }
    }
}