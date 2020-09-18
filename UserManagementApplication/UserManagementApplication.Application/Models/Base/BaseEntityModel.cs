using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagementApplication.Application.Models.Base
{
    public class BaseEntityModel
    {
        [Display(Name ="User ID")]
        public int Id { get; set; }
    }
}
