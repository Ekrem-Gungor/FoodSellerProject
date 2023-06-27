using Entitiy_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Bırakmayınız!");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Lütfen Şirket Adını Boş Bırakmayınız!");
            RuleFor(x => x.CustomerPassword).NotEmpty().WithMessage("Lütfen Şifreyi Boş Bırakmayınız!");
            RuleFor(x => x.CustomerPassword).MinimumLength(5).WithMessage("Lütfen en az 5 karakterden fazla değer girişi yapınız!");
            RuleFor(x => x.ContactNo).MaximumLength(11).WithMessage("Lütfen 11 karakterli bir telefon numarası girişi yapınız!");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen en az 3 karakterden fazla değer girişi yapınız!");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayınız!");
        }
    }
}
