using System.Net;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entites.Concrete;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var productListviewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productListviewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "product was succesfully added");
            }

            return RedirectToAction("Add");
        }

        [HttpGet]
        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product =_productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Updated(product);
                TempData.Add("message", "product was succesfully Updated");
            }
            return RedirectToAction("Update");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", "product was succesfully Deleted");
            return RedirectToAction("Index");
        }
    }
}