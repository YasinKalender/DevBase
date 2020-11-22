using DevBase.Dto.DTOs.CategoryDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.ValidationRules
{
    public class CaetgoryAddValidation:AbstractValidator<CategoryAddDto>
    {
        public CaetgoryAddValidation()
        {
            RuleFor(i => i.CategoryName).NotNull().WithMessage("Bu alan zorunludur");
        }

    }
}
