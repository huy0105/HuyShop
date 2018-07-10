namespace HuyShop.Data.Migrations
{
    using HuyShop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HuyShop.Data.HuyShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HuyShop.Data.HuyShopDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new HuyShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new HuyShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "huy",
                Email = "huynv@nal.vn",
                EmailConfirmed = true,
                Birthday = DateTime.Now,
                FullName = "Technology Education"

            };
            manager.Create(user, "123456abc");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("huynv@nal.vn");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
