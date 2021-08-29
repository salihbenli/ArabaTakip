using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AracısValidator : AbstractValidator<AracIslemleri>
    {
        public AracısValidator()
        {
            RuleFor(x => x.AracId).NotEmpty().WithMessage("Id boş olmamalı");
        }
    }

}
