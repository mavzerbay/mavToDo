using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MavToDo.MVCWebUI.View_Components
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName = HttpContext.User.Identity.Name,
            };
            return View(model);
        }
    }
}
