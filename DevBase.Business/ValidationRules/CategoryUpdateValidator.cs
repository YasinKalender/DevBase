using DevBase.Dto.DTOs.CategoryDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.ValidationRules
{
    public class CategoryUpdateValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(i => i.CategoryName).NotNull().WithMessage("Bu alan zorunlu alan");
        }

    }
}
