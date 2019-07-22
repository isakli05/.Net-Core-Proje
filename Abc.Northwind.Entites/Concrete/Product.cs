using System.ComponentModel.DataAnnotations;
using Abc.Core.Entities;

namespace Abc.Northwind.Entites.Concrete
{
    public class Product:IEntity
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public string ProductName { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        
        [Required]
        public decimal UnitPrice { get; set; }
        
        [Required]
        public short UnitsInStock { get; set; }
    }
}