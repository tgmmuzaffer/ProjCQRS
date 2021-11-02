﻿namespace ProjCQRS.Mvc.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ProjCQRS.Mvc.Models;
    using ProjCQRS.Mvc.Repository.IRepository;
    using Microsoft.AspNetCore.Http.Extensions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        [Route("Product")]//anasayfası   Crud ların sıralandığı bir menu birde arama menu
        public IActionResult Index()
        {
            return View();
        }

        [Route("Product-List")]
        [Route("Product-List/{slug}")]
        public async Task<IActionResult> Productlist(string slug = "")
        {
            //hız açısından memory de tutulabilir sayfa arası geçişlerde ve ilk açılış haricinde hız katıcaktır
            ViewBag.Url = this.HttpContext.Request.GetEncodedUrl();
            var categorylist = await _categoryRepository.GetAllAsync(ApiStatics.CqrsStatics.GetCategories);
            var productlist = await _productRepository.GetAllAsync(ApiStatics.CqrsStatics.GetProducts);
            if (!string.IsNullOrEmpty(slug) && slug == "True")
            {
                productlist = productlist.Where(a => a.Category != null && a.Category.CategoryName != null && a.Category.MinStockQuantity < a.Quantity).ToList();
            }
            else
            {
                productlist = productlist.Where(a => a.Category != null && a.Category.CategoryName != null).ToList();
            }
            return View(productlist);
        }

        [Route("Product-Detail/{Id}")]
        public async Task<IActionResult> ProductDetail(int Id)
        {
            var productdetail = await _productRepository.GetAsync(ApiStatics.CqrsStatics.GetProduct, Id);
            return View(productdetail);
        }

        [HttpGet("Create-Product")]//fromun olduğu sayfa olucak işlem bittikten sonra id ile sorgulamaya gönderip ekrana basıcaz
        public async Task<IActionResult> CreateProduct()
        {
            var categorylist = await _categoryRepository.GetAllAsync(ApiStatics.CqrsStatics.GetCategories);
            List<SelectListItem> categorySelectList = new List<SelectListItem>();
            foreach (var item in categorylist.OrderBy(a => a.CategoryName))
            {
                categorySelectList.Add(new SelectListItem() { Text = item.CategoryName, Value = item.Id.ToString(), Selected = (item.Id == 1 ? true : false), });
            }

            ViewBag.Categorylist = categorySelectList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var result = await _productRepository.CreateAsync(ApiStatics.CqrsStatics.CreateProduct, product);
            if (result!=null)
            {
                return PartialView("_Success");
            }
            return PartialView("_FailUpdate", product);
        }

        [Route("Update-Product/{Id}")]//detayı gösterilecek buradan update edicek
        public async Task<IActionResult> UpdateProduct(int Id)
        {
            var productdetail = await _productRepository.GetAsync(ApiStatics.CqrsStatics.GetProduct, Id);
            var categorylist = await _categoryRepository.GetAllAsync(ApiStatics.CqrsStatics.GetCategories);
            List<SelectListItem> categorySelectList = new List<SelectListItem>();
            if (categorylist.Count() > 0)
            {
                foreach (var item in categorylist.OrderBy(a => a.CategoryName))
                {
                    categorySelectList.Add(new SelectListItem() { Text = item.CategoryName, Value = item.Id.ToString(), Selected = (item.Id == 1 ? true : false), });
                }
                ViewBag.Categorylist = categorySelectList;
            }

            return View(productdetail);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductdetail(Product product)
        {
            var result = await _productRepository.UpdateAsync(ApiStatics.CqrsStatics.UpdateProduct, product);
            if (result != null)
            {
                return PartialView("_Success");
            }
            return PartialView("_FailUpdate", product);
        }


        [Route("Delete-Product/{Id}")]//listeleme sayfasından gelen id ye göre silme işlemi
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            var productdetail = await _productRepository.GetAsync(ApiStatics.CqrsStatics.GetProduct, Id);
            if (_productRepository.DeleteAsync(ApiStatics.CqrsStatics.DeleteProduct, Id).Result)
            {
                return PartialView("_Success");
            }
            return PartialView("_FailDelete", productdetail);
        }
    }
}
