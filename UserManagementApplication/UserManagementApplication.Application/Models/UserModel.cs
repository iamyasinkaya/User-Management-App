using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UserManagementApplication.Application.Models.Base;

namespace UserManagementApplication.Application.Models
{
    public class UserModel : BaseEntityModel
    {
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Display(Name = "Email Address")]

        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }
    }
}
