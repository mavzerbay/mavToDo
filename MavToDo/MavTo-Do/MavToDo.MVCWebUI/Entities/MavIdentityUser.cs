using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Business.Abstract;
using MavToDo.DataAccess.Abstract;
using MavToDo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace MavToDo.MVCWebUI.Entities
{
    public class MavIdentityUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
    