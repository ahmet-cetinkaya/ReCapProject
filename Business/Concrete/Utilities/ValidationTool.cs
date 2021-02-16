using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Business.Concrete.Utilities
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, IValidationContext entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}