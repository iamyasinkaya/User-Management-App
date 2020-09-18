using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UserManagementApplication.Core.Entities.Base;

namespace UserManagementApplication.Core.Entities
{
    public class User : BaseEntity
    {
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
