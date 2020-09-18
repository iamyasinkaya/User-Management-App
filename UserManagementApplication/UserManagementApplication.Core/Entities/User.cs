using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UserManagementApplication.Core.Entities.Base;

namespace UserManagementApplication.Core.Entities
{
    public class User : BaseEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageUrl { get; set; }


    }
}
