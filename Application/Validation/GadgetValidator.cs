using Application.DTOs;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation
{
    public class GadgetDtoValidator : AbstractValidator<GadgetDto>
    {
        public GadgetDtoValidator()
        {
            RuleFor(g => g.ProductName).NameRules();
            RuleFor(g => g.Cost).CostRules();

            RuleFor(g => g.Brand)
                .MaximumLength(2).WithMessage("Brand must not exceed 50 characters.");
        }
    }
}


//using FluentValidation;
//using Application.DTOs;

//namespace Application.Validation
//{
//    public class GadgetDtoValidator : AbstractValidator<GadgetDto>
//    {
//        public GadgetDtoValidator()
//        {
//            RuleFor(x => x.ProductName)
//                .NotEmpty().WithMessage("Product name is required")
//                .MaximumLength(100).WithMessage("Product name cannot exceed 100 characters");

//            RuleFor(x => x.Brand)
//                .NotEmpty().WithMessage("Brand is required")
//                .MaximumLength(50).WithMessage("Brand cannot exceed 50 characters");

//            RuleFor(x => x.Cost)
//                .GreaterThan(0).WithMessage("Cost must be greater than 0");

//            RuleFor(x => x.ImageName)
//                .MaximumLength(255).WithMessage("Image name cannot exceed 255 characters");

//            RuleFor(x => x.Type)
//                .MaximumLength(50).WithMessage("Type cannot exceed 50 characters");
//        }
//    }
//}
