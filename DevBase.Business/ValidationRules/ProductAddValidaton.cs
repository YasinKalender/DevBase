using DevBase.Dto.DTOs.ProductDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.ValidationRules
{
    public class ProductAddValidaton:AbstractValidator<ProductAddDto>
    {

        public ProductAddValidaton()
        {
            RuleFor(i => i.ProductName).NotNull().WithMessage("Bu alan zorunlu alandır");
            RuleFor(i => i.ProductDescription).NotNull().WithMessage("Bu alan zorunlu alandır");
            RuleFor(i => i.CategoryID).ExclusiveBetween(-1, int.MaxValue).WithMessage("Lütfen Kategori seçiniz");
        }
    }
}
