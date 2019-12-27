using System.Collections.Generic;
using MavToDo.Entities.Concrete;

namespace MavToDo.MVCWebUI.Models
{
    public class ThingsToDoListViewModel
    {
        public List<ThingsToDo> ThingsToDos { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public string CurrentName { get; set; }
        public int CurrentPage { get; set; }
    }
}