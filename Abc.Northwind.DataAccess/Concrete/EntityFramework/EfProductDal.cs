using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
    }
}