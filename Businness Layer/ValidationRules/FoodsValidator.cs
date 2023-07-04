using Entitiy_Layer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.ValidationRules
{
    public class FoodsValidator : AbstractValidator<Foods>
    {
        public FoodsValidator() 
        {
            RuleFor(x => x.FoodName).NotEmpty().WithMessage(" Lütfen Ürün Adını Boş Bırakmayınız!");
            RuleFor(x => x.FInStock).NotEmpty().WithMessage(" Lütfen Bir Stok Miktarı Belirtiniz!");
            RuleFor(x => x.FInStock).MinimumLength(1).WithMessage(" Lütfen '0' Gibi Boş Sayı İçeren Değer Girişi Yapmayınız!");
            RuleFor(x => x.FUnitPrice).NotEmpty().WithMessage(" Lütfen Ürün'ün Fiyatını Boş Bırakmayınız!");
            RuleFor(x => x.FUnitPrice).MinimumLength(1).WithMessage(" Lütfen '0' Gibi Boş Sayı İçeren Değer Girişi Yapmayınız!");
            //RuleFor(x => x.FoodLCD).NotEmpty().WithMessage(" Lütfen Ürün'ün Son Tüketim Tarihini Belirtiniz!");
            //RuleFor(x => x.FoodSLT).NotEmpty().WithMessage(" Lütfen Ürün'ün Raf Ömrü Tarihini Belirtiniz!");
            //RuleFor(x => x.FoodPDate).NotEmpty().WithMessage(" Lütfen Ürün'ün Üretim Tarihini Belirtiniz!");
        }
    }
}
