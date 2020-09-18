using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Application.Models;

namespace UserManagementApplication.Application.FluentValidation
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotNull().WithMessage("This field should not be empty.");
            RuleFor(user => user.LastName).NotNull().WithMessage("This field should not be empty.");
            RuleFor(user => user.EmailAddress).NotNull().WithMessage("This field should not be empty.");
            RuleFor(user => user.PhoneNumber).NotNull().WithMessage("This field should not be empty.");

        }
    }
}
