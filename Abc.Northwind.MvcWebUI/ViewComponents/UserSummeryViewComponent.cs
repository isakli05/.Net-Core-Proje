using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Abc.Northwind.MvcWebUI.ViewComponents
{
    public class UserSummeryViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName=HttpContext.User.Identity.Name  
            };
            return View(model);
        }
    }
}