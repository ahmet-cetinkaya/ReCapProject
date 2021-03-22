using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    internal class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentStartDate).LessThan(r => r.RentEndDate);
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.RentStartDate);
        }
    }
}