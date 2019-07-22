using System.Collections.Generic;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.Business.Concrete
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
    }
}