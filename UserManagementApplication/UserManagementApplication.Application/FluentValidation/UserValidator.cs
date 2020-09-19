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
            RuleFor(user => user.EmailAddress).NotNull().EmailAddress().WithMessage("This field should not be empty.");
            RuleFor(user => user.PhoneNumber).NotNull().WithMessage("This field should not be empty.");
            RuleFor(user => user.DateOfBirth).NotNull();
            RuleFor(user => user.ImageUrl).NotNull();



            //Minimum - Maximum Lenght

            RuleFor(user => user.FirstName).MinimumLength(2).MaximumLength(30);
            RuleFor(user => user.FirstName).MinimumLength(2).MaximumLength(30);
            RuleFor(user => user.PhoneNumber).MinimumLength(11).MinimumLength(11);





        }
    }
}
