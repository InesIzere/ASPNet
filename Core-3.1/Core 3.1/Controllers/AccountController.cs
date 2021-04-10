using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SLE_System.Models;

namespace Core_3._1.Controllers
{

    //[Authorize]
    //public class AccountController : Controller
    //{
    //    private readonly UserManager<IdentityUser> _userManager;
    //    private readonly SignInManager<IdentityUser> _signInManager;

    //    public AccountController()
    //    {
    //    }

    //    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //    }


    //    //
    //    // GET: /Account/Login
    //    [AllowAnonymous]
    //    public IActionResult Login()
    //    {
    //        return View();
    //    }

    //    //
    //    // POST: /Account/Login
    //    [HttpPost]
    //    [AllowAnonymous]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Login(LoginViewModel user)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);
    //            if (result.Succeeded)
    //            {
    //                return RedirectToAction("Index", "Home");

    //            } else
    //            {
    //                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
    //                return View(user);
    //            }
    //        }
    //        return View(user);

    //    }

    //    //
    //    // GET: /Account/Register
    //    [AllowAnonymous]
    //    public ActionResult Register()
    //    {
    //        return View();
    //    }

    //    //
    //    // POST: /Account/Register
    //    [AllowAnonymous]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Register(RegisterViewModel model)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //                var httpClient = new HttpClient();
    //                var result = await _userManager.CreateAsync(userManager, model.Password);
    //            if (result.Succeeded)
    //            {
    //                await SignInManager<IdentityUser>.SignInAsync(userManager, isPersistent: false, rememberBrowser: false);

    //                return RedirectToAction("Index", "Home");
    //            }
                
    //        }

    //        // If we got this far, something failed, redisplay form
    //        return View(model);
    //    }

    //    [AllowAnonymous]
    //        public async Task<IActionResult> Logout()
    //        {
    //            await _signInManager.SignOutAsync();

    //            return RedirectToAction("Login");
    //        }

    //}

    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            //var httpClient = new HttpClient();
            //HttpResponseMessage response = await httpClient.GetAsync("https://rocketclevatorscustomer.herokuapp.com/api/customers/email/{model.Email}");
            // && response.StatusCode == System.Net.HttpStatusCode.OK
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            //var branch = new Branch
            //{
            //    branchName = "Regie",
            //    address = "Naval"

            //};
            //branchContext.Branch.Add(branch);
            //branchContext.SaveChanges();

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}