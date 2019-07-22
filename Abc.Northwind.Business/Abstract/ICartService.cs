using System.Collections.Generic;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}