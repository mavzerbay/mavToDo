using System;
using System.Collections.Generic;
using System.Text;
using MavToDo.Business.Abstract;
using MavToDo.DataAccess.Abstract;
using MavToDo.Entities.Concrete;

namespace MavToDo.Business.Concrete
{
    public class ThingsToDoManager : IThingsToDoService
    {
        private IThingsToDoDal _thingsToDoDal;

        public ThingsToDoManager(IThingsToDoDal thingsToDoDal)
        {
            _thingsToDoDal = thingsToDoDal;
        }

        public void Add(ThingsToDo thingsToDo)
        {
            var category = new Category();

            if (category==null||thingsToDo==null)
            {
                return;
            }
            _thingsToDoDal.Add(new ThingsToDo
            {
                CategoryId = category.CategoryId,
                ThingsToDoColor = thingsToDo.ThingsToDoColor,
                ThingsToDoStart = thingsToDo.ThingsToDoStart,
                ThingsToDoEnd = thingsToDo.ThingsToDoEnd,
                ThingsToDoName = thingsToDo.ThingsToDoName
            });
        }

        public void Delete(int thingsToDoId)
        {
            _thingsToDoDal.Delete(new ThingsToDo{ThingsToDoId = thingsToDoId});
        }

        public List<ThingsToDo> GetAll()
        {
            return _thingsToDoDal.GetList();
        }

        public ThingsToDo GetById(int thingsId)
        {
            return _thingsToDoDal.Get(t => t.ThingsToDoId == thingsId);
        }

        public List<ThingsToDo> GetByCategory(int categoryId)
        {
            return _thingsToDoDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Update(ThingsToDo thingsToDo)
        {
            _thingsToDoDal.Update(thingsToDo);
        }
        public List<ThingsToDo> GetAllByUserId(string userId)
        {
            return _thingsToDoDal.GetList(u => u.UserId == userId);
        }
    }
}
