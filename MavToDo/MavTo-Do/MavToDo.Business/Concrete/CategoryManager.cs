using System;
using System.Collections.Generic;
using System.Text;
using MavToDo.Business.Abstract;
using MavToDo.DataAccess.Abstract;
using MavToDo.Entities.Concrete;

namespace MavToDo.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category GetById(int categoryId)
        {
           return _categoryDal.Get(i => i.CategoryId == categoryId||categoryId==0);
        }

        public Category Get()
        {
            return _categoryDal.Get();
        }

    }
}
