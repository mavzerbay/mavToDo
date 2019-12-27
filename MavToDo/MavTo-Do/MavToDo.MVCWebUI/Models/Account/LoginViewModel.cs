using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.MVCWebUI.Entities;

namespace MavToDo.MVCWebUI.Models.Account
{
    public class LoginViewModel
    {

        [Required,Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required,Display(Name = "Password"),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
