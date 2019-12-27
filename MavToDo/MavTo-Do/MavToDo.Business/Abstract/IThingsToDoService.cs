using System;
using System.Collections.Generic;
using System.Text;
using MavToDo.Entities.Concrete;

namespace MavToDo.Business.Abstract
{
    public interface IThingsToDoService
    {
        List<ThingsToDo> GetAll();
        List<ThingsToDo> GetAllByUserId(string userId);
        ThingsToDo GetById(int thingsId);
        List<ThingsToDo> GetByCategory(int categoryId);
        void Add(ThingsToDo thingsToDo);
        void Update(ThingsToDo thingsToDo); 
        void Delete(int thingsToDoId);
    }
}
