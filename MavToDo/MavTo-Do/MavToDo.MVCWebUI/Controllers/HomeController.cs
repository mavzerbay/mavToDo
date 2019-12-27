using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MavToDo.MVCWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace MavToDo.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IThingsToDoService _thingsToDoService;

        public HomeController(IThingsToDoService thingsToDoService)
        {
            _thingsToDoService = thingsToDoService;
        }


        [Authorize]
        public IActionResult Index(int page=1,int category=0)
        {
            var userId = HttpContext.Session.GetString("userId");
            var userName = HttpContext.Session.GetString("userName");

            var pageSize = 10;
            var thingsToDo = _thingsToDoService.GetAllByUserId(userId);

            ThingsToDoListViewModel things = new ThingsToDoListViewModel
            {
                ThingsToDos = thingsToDo.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(thingsToDo.Count/(double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage=page
            };

            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName = userName,
                UserId = userId
            };
            return View(things);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
