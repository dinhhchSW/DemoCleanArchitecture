using FluentValidation;

namespace Application.Validation
{
    public static class CommonValidators
    {
        public static IRuleBuilderOptions<T, string?> NameRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(255).WithMessage("Name must not exceed 255 characters.");
        }
        public static IRuleBuilderOptions<T, decimal?> CostRules<T>(this IRuleBuilder<T, decimal?> ruleBuilder)
        {
            return ruleBuilder
                .NotNull().WithMessage("Cost is required.")
                .GreaterThan(0).WithMessage("Cost must be greater than zero.");
        }
    }
}
