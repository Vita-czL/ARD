using ARD.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ARD.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> singInManager;
        private readonly UserManager<AppUser> userManager;

        public AccountController( SignInManager<AppUser> singInManager)
        {
            this.singInManager = singInManager;
            this.userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
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
        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid) 
            {
                AppUser user = new()
                {
                    Nickname = model.Nickname,
                    Email = model.Email,
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await singInManager.SignInAsync(user, false);

                    return RedirectToAction("Index","Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await singInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}