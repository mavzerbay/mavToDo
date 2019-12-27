using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Mav.Core.Entities;

namespace MavToDo.Entities.Concrete
{
    public class ThingsToDo:IEntity
    {
        [Required]
        public int ThingsToDoId { get; set; }
        [Required]
        public string ThingsToDoName { get; set; }
        public DateTime ThingsToDoStart { get; set; }
        [Required]
        public DateTime ThingsToDoEnd { get; set; }
        public string ThingsToDoColor { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public string UserId { get; set; }
    }
}
