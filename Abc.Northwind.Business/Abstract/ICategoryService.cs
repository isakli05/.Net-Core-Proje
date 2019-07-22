using System.Collections.Generic;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}