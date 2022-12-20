using DocumentManagementSystem.UI.Models;
using FluentValidation;

namespace DocumentManagementSystem.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Password can't be empty");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Password should be at least 3 characters.");
            RuleFor(x=>x.Password).Equal(x=>x.ConfirmPassword).WithMessage("Passwords not match.");
            RuleFor(x=>x.Username).MinimumLength(3).NotEmpty().WithMessage("Username should be at least 3 characters."); ;
            RuleFor(x=>x.PhoneNumber).NotEmpty().WithMessage("Phone number can't be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can't be empty");
            RuleFor(x=>x.FirstName).NotEmpty().WithMessage("Firstname  can't be empty");
            RuleFor(x=>x.LastName).NotEmpty().WithMessage("Lastname  can't be empty");
            RuleFor(x=>x.DeparmentId).NotEmpty().WithMessage("Departments can't be empty");
        }
    }
}
