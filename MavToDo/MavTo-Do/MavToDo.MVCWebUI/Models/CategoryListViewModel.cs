using System.Collections.Generic;
using MavToDo.Entities.Concrete;

namespace MavToDo.MVCWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
        public string CurrentCategoryName { get; set; }
    }
}