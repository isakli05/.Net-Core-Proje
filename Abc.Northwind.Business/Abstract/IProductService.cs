using System.Collections.Generic;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int CategoryId);
        void Add(Product product);
        void Updated(Product product);
        void Delete(int ProductId);
        Product GetById(int productId);
    }
    
}