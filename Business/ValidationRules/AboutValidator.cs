using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("You cannot leave the description part blank....!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please pick picture...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Please enter a 50 character description message...!");
            RuleFor(x=>x.Description).MaximumLength(1500).WithMessage("Please shorten the description");
        }
    }
}
