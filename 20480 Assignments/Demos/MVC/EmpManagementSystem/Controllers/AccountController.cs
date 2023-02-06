using EmpManagementSystem.Models;
using EmpManagementSystem.Services;
using EmpManagementSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> _signInMng; //signs in user
        private UserManager<User> _userManager; //creates user in register
        public AccountController(SignInManager<User> signIn, UserManager<User> userManager)
        {
            this._signInMng = signIn;
            this._userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if(this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInMng.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Employee");
                }
            }
            ModelState.AddModelError("", "Failed to login");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInMng.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                EmpManagementSystem.Models.User newUser = new EmpManagementSystem.Models.User();
                newUser.firstName = registerViewModel.FirstName;
                newUser.lastName = registerViewModel.LastName;
                newUser.PhoneNumber = registerViewModel.PhoneNumber.ToString();
                newUser.Email = registerViewModel.Email;
                newUser.UserName= registerViewModel.UserName;

                var result = await _userManager.CreateAsync(newUser, registerViewModel.Password);
                if(result.Succeeded)
                {
                    if(newUser.UserName == "Admin")
                    {
                        await _userManager.AddToRoleAsync(newUser, "Admin");
                        await _userManager.AddToRoleAsync(newUser, "Employee");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(newUser, "Employee");
                    }
                    return RedirectToAction("Login", "Account");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            ModelState.AddModelError("", "Failed to create account");
            return View(registerViewModel);
        }
    }
}
