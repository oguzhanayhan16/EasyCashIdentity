using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentity.PresentationLayer.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {

                Code = "PasswordTooShort",
                Description = $"Parola en az {length} karaker olmalıdır"

            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {

                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 küçük harf giriniz."

            };
        }

    }
}
