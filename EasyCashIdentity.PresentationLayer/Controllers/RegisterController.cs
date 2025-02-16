
using EasyCashIdentity.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentity.EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EasyCashIdentity.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegister)
        {
            if (ModelState.IsValid)
            {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegister.Username,
                    Name = appUserRegister.Name,
                    Email = appUserRegister.Email,
                    SurName = appUserRegister.Surname,
                    City = "asd",
                    District = "bb",
                    ImageUrl = "c",
                    ConfirmCode= code
                };
                var resutl = await _userManager.CreateAsync(appUser, appUserRegister.Password);
                if (resutl.Succeeded)
                {
                    MimeMessage mime = new MimeMessage();
                    MailboxAddress mailbox = new MailboxAddress("Easy Cash Admin", "oguzhanayhan35@gmail.com");
                    MailboxAddress mail = new MailboxAddress("User",appUser.Email);

                    mime.From.Add(mailbox);
                    mime.To.Add(mail);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodu: " + code;
                    mime.Body=bodyBuilder.ToMessageBody();

                    mime.Subject = "Easy Cash Onay Kodu";

                    SmtpClient client = new SmtpClient();
                    client.Connect("smtp.gmail.com",587,false);
                    client.Authenticate("oguzhanayhan35@gmail.com", "");
                    client.Send(mime);
                    client.Disconnect(true);

                    TempData["Mail"] = appUserRegister.Email;

                }
                else
                {

                    foreach (var item in resutl.Errors)
                    {

                        ModelState.AddModelError("",item.Description);
                            
                    }

                }
            }


            return View();
        }

        public IActionResult Indeax()
        {
            return View();
        }

    }
}
