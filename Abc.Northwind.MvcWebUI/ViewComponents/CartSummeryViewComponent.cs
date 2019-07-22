using Abc.Northwind.MvcWebUI.Models;
using Abc.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Abc.Northwind.MvcWebUI.ViewComponents
{
    public class CartSummeryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummeryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummeryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}