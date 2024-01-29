﻿using ETicaret.MvcWebUI.Identity;
using ETicaret.MvcWebUI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController() 
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);
            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore); 
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {

            if(ModelState.IsValid)
            {
                //Kayıt işlemleri

                var user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.SurName;
                user.Email = model.Email;
                user.UserName = model.UserName;

                var result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    //kullanıcı oluştu ve kullanıcıyı role atıyoz
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");

                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturma hatası.");
                }
            }

            return View(model);
        }


        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Login işlemleri

                var user = UserManager.Find(model.UserNameOrEmail, model.Password);

                if (user == null)
                {
                    // Kullanıcı adını küçük harfe çevirip tekrar deneyin
                    var lowerUserNameOrEmail = model.UserNameOrEmail.ToLower();
                    user = UserManager.Find(lowerUserNameOrEmail, model.Password);
                }

                if (user != null)
                {
                    // varolan kullanıcıyı sisteme dahil et
                    // cookie oluştur
                    // ApplicationCookie oluşturup sisteme bırak

                    var authManager = HttpContext.GetOwinContext().Authentication;

                    var identityClaims = UserManager.CreateIdentity(user, "ApplicationCookie");

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe
                    };

                    authManager.SignIn(authProperties, identityClaims);


                    if(!string.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok.");
                }
            }

            return View(model);
        }




        // GET: Account
        public ActionResult Logout()
        {

            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index","Home");
        }

    }
}