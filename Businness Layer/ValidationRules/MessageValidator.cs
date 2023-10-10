using Entitiy_Layer.Concrete;
using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail Adresinizi Boş Bırakmayınız!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Lütfen Boş Bırakmayınız!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Lütfen Boş Bırakmayınız!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız!");
        }
    }
}
