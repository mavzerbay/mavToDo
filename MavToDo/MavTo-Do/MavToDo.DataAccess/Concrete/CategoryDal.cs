using System;
using System.Collections.Generic;
using System.Text;
using Mav.Core.DataAccess.EntityFramework;
using MavToDo.DataAccess.Abstract;
using MavToDo.Entities.Concrete;

namespace MavToDo.DataAccess.Concrete
{
    public class CategoryDal :EfEntityRepositoryBase<Category,MavContext>,ICategoryDal
    {
    }
}
