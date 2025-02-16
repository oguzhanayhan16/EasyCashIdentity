using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.PresentationLayer.Controllers
{
    public class ConfrimMailController : Controller
    {
        private readonly UserManager<AppUser> _user;

        [HttpGet]
        public IActionResult Index(int id)
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel cm)
        {
            var user = await _user.FindByEmailAsync(cm.Mail);
            if (user.ConfirmCode == cm.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _user.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
