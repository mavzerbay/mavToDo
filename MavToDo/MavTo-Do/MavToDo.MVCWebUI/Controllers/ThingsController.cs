using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Business.Abstract;
using MavToDo.Entities.Concrete;
using MavToDo.MVCWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MavToDo.MVCWebUI.Controllers
{
    public class ThingsController : Controller
    {
        private IThingsToDoService _thingsToDoService;
        private ICategoryService _categoryService;
        

        public ThingsController(IThingsToDoService thingsToDoService, ICategoryService categoryService)
        {
            _thingsToDoService = thingsToDoService;
            _categoryService = categoryService;
        }

        
        public ActionResult AddThings([FromQuery(Name = "categoryId")] int categoryId,[FromQuery(Name = "categoryName")] string categoryName)
        {
                var model = new ThingsAddViewModel  
            {
                CategoryId = categoryId,
                CategoryName = categoryName
            };
                return View(model);

            
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult AddThings(ThingsAddViewModel thingsAddViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            var things = new ThingsToDo()
            {
                CategoryId = thingsAddViewModel.CategoryId,
                ThingsToDoName = thingsAddViewModel.ThingsToDo.ThingsToDoName,
                ThingsToDoStart = thingsAddViewModel.ThingsToDo.ThingsToDoStart,
                ThingsToDoEnd = thingsAddViewModel.ThingsToDo.ThingsToDoEnd,
                ThingsToDoColor = thingsAddViewModel.ThingsToDo.ThingsToDoColor,
                UserId=userId
                
            };

            _thingsToDoService.Add(things);
            return RedirectToAction("Index","Things");
        }

        public ActionResult Index(int page=1,int category=1,[FromQuery(Name = "menu")]string categoryName ="Main")
        {
            
            var userId = HttpContext.Session.GetString("userId");
            var pageSize = 10;
            var things = _thingsToDoService.GetAllByUserId(userId);
            ThingsToDoListViewModel model = new ThingsToDoListViewModel()
            {
                ThingsToDos = things.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(things.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentName =   categoryName,
                CurrentPage = page
            };
            return View(model);
        }

        public ActionResult Delete(int thingsId)
        {
            _thingsToDoService.Delete(thingsId);
            TempData.Add("delete","To do things was successfully deleted!");
            return RedirectToAction("Index","Home");
        }

    }
}