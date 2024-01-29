using ETicaret.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            // Roller

            if (!context.Roles.Any(i => i.Name == "admin")) 
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() {Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }


            if (!context.Roles.Any(i => i.Name == "emirkıvrak"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Emir", Surname = "Kıvrak", UserName = "emirkivrak", Email = "emirkivrak@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
                manager.AddToRole(user.Id, "admin");
            }

            if (!context.Roles.Any(i => i.Name == "emirkıvrak"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Ayyüce", Surname = "Abban", UserName = "ayyüceabban", Email = "ayyüceabban@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
                
            }



            // User


            base.Seed(context);
        }


    }
}