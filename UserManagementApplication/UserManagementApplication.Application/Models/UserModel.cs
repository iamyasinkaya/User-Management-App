using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UserManagementApplication.Application.Models.Base;

namespace UserManagementApplication.Application.Models
{
    public class UserModel : BaseEntityModel
    {
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }


        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        [Display(Name = "Image")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
    }
}
