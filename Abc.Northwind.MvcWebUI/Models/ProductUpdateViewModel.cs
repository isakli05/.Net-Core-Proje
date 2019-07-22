using System.Collections.Generic;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {   
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}