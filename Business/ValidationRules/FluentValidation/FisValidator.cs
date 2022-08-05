using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class FisValidator : AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(p => p.Date).NotEmpty();
            RuleFor(p => p.Company).NotEmpty();
            RuleFor(p => p.FisType).NotEmpty();
            RuleFor(p => p.VatValue).GreaterThan(0);
            RuleFor(p => p.Description).NotEmpty();
        }

    }
}
