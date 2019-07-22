using System.Collections.Generic;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}