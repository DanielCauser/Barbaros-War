﻿using System;
using System.Threading.Tasks;

using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;
using BARBAROS.MVC.Models;
using BARBAROS.MVC.App_Start;
using BARBAROS.REPOSITORIO.Context;

[assembly: OwinStartup(typeof(BARBAROS.MVC.Startup))]

namespace BARBAROS.MVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(BARBAROS.REPOSITORIO.Context.ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            
        }

    }
}
