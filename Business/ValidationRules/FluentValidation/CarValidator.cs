using Entities.Concrete;
using FluentValidation;

namespace ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}