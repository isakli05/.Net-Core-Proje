using Abc.Core.Entities;

namespace Abc.Northwind.Entites.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}