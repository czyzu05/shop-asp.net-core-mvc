using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Login(string returnUrl)
        {
            return View(new Login() { 
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (!ModelState.IsValid)
                return View(login);

            var user = await _userManager.FindByNameAsync(login.UserName);

            if(user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(login.ReturnUrl))
                        return RedirectToAction("Index", "Home");
                    return Redirect(login.ReturnUrl);
                }
            }
            ModelState.AddModelError("", "UserName/Password not found");
            return View(login);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = login.UserName };
                var result = await _userManager.CreateAsync(user, login.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(login);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
