using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilşemez");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı En Fazla 20 Karakter Olabilir.");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori Adı En Az 5 Karakter Olabilir.");


        }
    }
}
