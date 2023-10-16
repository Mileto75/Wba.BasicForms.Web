﻿using Microsoft.AspNetCore.Mvc;
using Wba.BasicForms.Web.ViewModels;

namespace Wba.BasicForms.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            //shows the form to the user
            AccountLoginViewModel accountLoginViewModel = new();
            accountLoginViewModel.RememberMe = true;
            return View(accountLoginViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountLoginViewModel accountLoginViewModel)
        {
            //handles the form data
            var username = accountLoginViewModel.Username;
            var password = accountLoginViewModel.Password;
            //check in database
            //check password
            
            if(username == "miletoRules@awesome.com" &&  password == "Test123" )
            {
                //redirect to reset the form data 
                return RedirectToAction("Index", "Home");
            }
            //If errors
            //return view
            return View(accountLoginViewModel);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(AccountRegisterViewModel accountRegisterViewModel)
        {
            //simulate registration
            //if ok redirect
            return RedirectToAction("Registered");
            //else return View()
        }

        [HttpGet]
        public IActionResult Registered()
        {
            return View();
        }
    }
}
