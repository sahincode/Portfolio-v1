using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.DTOs.EmployeeModelDTOs
{
    public class EmployeeCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }
        public List<string> Professions { get; set; }
        public string ImageUrl { get; set; }
        public string LinkedIn { get; set; }
        public string Insta { get; set; }
        public string Facebook { get; set; }
        public string GitHub { get; set; }
    }
    public class EmployeeCreateDtoValidator : AbstractValidator<EmployeeCreateDto>
    {
        public EmployeeCreateDtoValidator()
        {
            RuleFor(e => e.Name).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(200).WithMessage("Can not be greater than 200 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.Surname).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(200).WithMessage("Can not be greater than 200 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.ImageUrl).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(100).WithMessage("Can not be greater than 100 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.Insta).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(200).WithMessage("Can not be greater than 200 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.LinkedIn).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(200).WithMessage("Can not be greater than 200 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.Facebook).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(200).WithMessage("Can not be greater than 200 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.GitHub).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                 MaximumLength(200).WithMessage("Can not be greater than 200 digits").
                                 MinimumLength(3).WithMessage("Can not be less than 3 digits");
            RuleFor(e => e.Birthday).NotNull().WithMessage("Can not be null").
                                 NotEmpty().WithMessage("Can not be empty").
                                LessThan(DateTime.UtcNow.AddHours(4).AddYears(-18)).WithMessage("Employee must have greater than 18 years old.");
        }
    }
}
