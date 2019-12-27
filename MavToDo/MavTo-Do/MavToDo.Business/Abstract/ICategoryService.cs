using MavToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MavToDo.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get();
        void Add(Category category);    
        Category GetById(int categoryId);
    }
}
