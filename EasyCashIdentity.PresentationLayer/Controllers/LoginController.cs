using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signIn;
        private readonly UserManager<AppUser> _userM;

        public LoginController(SignInManager<AppUser> signIn, UserManager<AppUser> userM)
        {
            _signIn = signIn;
            _userM = userM;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel lg)
        {


            var result = await _signIn.PasswordSignInAsync(lg.Username, lg.Password, false, true);
            if (result.Succeeded)
            {
                var user = await _userM.FindByNameAsync(lg.Username);
                if (user.EmailConfirmed == true)
                {
                    return RedirectToAction("Index", "MyAccounts");
                }
                //else lütfen mail adresinizi onaylayın
            }
            //kullanıcı adı veya şifre hatalı
            return View();
        }
    }
}
