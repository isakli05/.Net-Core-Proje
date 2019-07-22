using System.Collections.Generic;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p=> p.CategoryId == categoryId || categoryId==0);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Updated(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
           _productDal.Delete(new Product {ProductId = productId});
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
    }
}