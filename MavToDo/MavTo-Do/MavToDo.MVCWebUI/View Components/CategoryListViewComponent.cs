using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Business.Abstract;
using MavToDo.MVCWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MavToDo.MVCWebUI.View_Components
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        private IHttpContextAccessor _context;

        public CategoryListViewComponent(ICategoryService categoryService, IHttpContextAccessor context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(_context.HttpContext.Request.Query["category"]),
                CurrentCategoryName = _context.HttpContext.Request.Query["categoryName"]
            };
            return View(model);
        }
    }
}
