using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete.Validation.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Daily price must be greater than 0.");
            RuleFor(c => c.Name).MinimumLength(2).WithMessage("Car name must be at least 2 characters.");
        }
    }
}