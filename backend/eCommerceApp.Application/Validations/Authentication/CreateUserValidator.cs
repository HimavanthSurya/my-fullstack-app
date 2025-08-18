using eCommerceApp.Application.DTOs.Identity;
using FluentValidation;


namespace eCommerceApp.Application.Validations.Authentication
{
    public class CreateUserValidator : AbstractValidator<CreateUser>
    {
        public CreateUserValidator() 
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full name is required.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be atleast 8 characters long.")
                .Matches(@"[A-Z]").WithMessage("Password must contain aleast one uppercase letter.")
                .Matches(@"[a-z]").WithMessage("Password must contain aleast one lowercase letter.")
                .Matches(@"\d").WithMessage("Password must contain atleast one number.")
                .Matches(@"[^\w]").WithMessage("Password must contain aleast one special character.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Passwords do not match");
        }
    }
}
