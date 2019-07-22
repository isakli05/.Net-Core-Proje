using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}