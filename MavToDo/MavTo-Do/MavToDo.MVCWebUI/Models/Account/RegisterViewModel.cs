using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Entities.Concrete;
using MavToDo.MVCWebUI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MavToDo.MVCWebUI.Models.Account
{
    public class RegisterViewModel
    {
        [Remote("Register", "Account", HttpMethod = "POST", ErrorMessage = "User name already registered."),Required(AllowEmptyStrings = false,ErrorMessage = "Please enter username"),Display(Name = "User Name"),RegularExpression("^[a-zA-Z0-9ğüşöçİĞÜŞÖÇ]+$")]
        public string UserName { get; set; }
        [Required,Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required,Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required,Display(Name = "Password"),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,Compare(nameof(Password),ErrorMessage = "Your password do not match"),Display(Name = "Confirm Password"),DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } 
        [Display(Name = "E-mail"),DataType(DataType.EmailAddress), Remote("Register", "Account", HttpMethod = "POST", ErrorMessage = "Email already registered."), Required(AllowEmptyStrings = false, ErrorMessage = "Please enter username")]
        public string Email { get; set; }
    }
}
