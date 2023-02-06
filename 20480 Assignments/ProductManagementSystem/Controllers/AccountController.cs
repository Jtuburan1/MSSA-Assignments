using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Models;
using ProductManagementSystem.ViewModels;

namespace ProductManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> _signIn;
        private UserManager<User> _userManager;
        
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signIn = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            if(this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if(ModelState.IsValid)
            {
                var result = await _signIn.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Failed to log in");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if(ModelState.IsValid)
            {
                ProductManagementSystem.Models.User newUser = new ProductManagementSystem.Models.User();
                newUser.firstName = register.FirstName;
                newUser.lastName = register.LastName;
                newUser.PhoneNumber = register.PhoneNumber.ToString();
                newUser.Email = register.Email;
                newUser.Role = register.Role;
                newUser.UserName = register.UserName;

                var result = await _userManager.CreateAsync(newUser, register.Password);
                if(result.Succeeded)
                {
                    if(newUser.Role == "Admin")
                    {
                        await _userManager.AddToRoleAsync(newUser, "Admin");
                        await _userManager.AddToRoleAsync(newUser, "Employee");
                        await _userManager.AddToRoleAsync(newUser, "Customer");
                    }
                    if(newUser.Role == "Employee")
                    {
                        await _userManager.AddToRoleAsync(newUser, "Employee");
                        await _userManager.AddToRoleAsync(newUser, "Customer");
                    }
                    if(newUser.Role == "Customer")
                    {
                        await _userManager.AddToRoleAsync(newUser, "Customer");
                    }
                    return RedirectToAction("Login", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            ModelState.AddModelError("", "Failed to create account");
            return View(register);
        }
    }
}
