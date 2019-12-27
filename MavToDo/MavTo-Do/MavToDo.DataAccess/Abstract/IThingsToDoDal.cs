using System;
using System.Collections.Generic;
using System.Text;
using Mav.Core.DataAccess;
using MavToDo.Entities.Concrete;

namespace MavToDo.DataAccess.Abstract
{
    public interface IThingsToDoDal: IEntityRepository<ThingsToDo>
    {
    }
}
