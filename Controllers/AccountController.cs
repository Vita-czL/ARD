using ARD.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ARD.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> singInManager;

        public AccountController(SignInManager<AppUser> singInManager)
        {
            this.singInManager = singInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                //login
                var result = await singInManager.PasswordSignInAsync(model.Nickname!, model.Password!, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
                ModelState.AddModelError("", "Invalid Login Attemp");
                return View(model);
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}