using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Business.Abstract;
using MavToDo.Entities.Concrete;

namespace MavToDo.MVCWebUI.Models
{
    public class ThingsAddViewModel
    {

        public ThingsToDo ThingsToDo { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }    
    }   
}
