using EntitiyLayer.Concrete;
using FluentValidation;

namespace Businness_Layer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresinizi Boş Bırakmayınız!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Lütfen Boş Bırakmayınız!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adınızı Lütfen Boş Bırakmayınız!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayınız!");
        }
    }
}
