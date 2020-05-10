using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindFramework.Web.ApiService;
using NorthwindFramework.Web.DTOs;

namespace NorthwindFramework.Web.Controllers
{
    public class ProductController : Controller
    {
       
        ProductApiService _productApiService;
        CategoryApiService _categoryApiService;


        public ProductController(ProductApiService productApiService, CategoryApiService categoryApiService)
        {
            _productApiService = productApiService;
            _categoryApiService = categoryApiService;
          
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productApiService.GetAllAsync();
            return View(products);
        }
        
        public async Task<IActionResult> Create()
        {
            ViewBag.Category = await _categoryApiService.GetAllAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductDto productDto)
        {
            var products = await _productApiService.AddAsync(productDto);
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var products = await _productApiService.GetByIdAsync(id);
            await _productApiService.Update(products);
            ViewBag.Category = await _categoryApiService.GetAllAsync();
            return View(products);
        }
 
        [HttpPost]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            var products = await _productApiService.Update(productDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var products = await _productApiService.Remove(id);
            return RedirectToAction("Index");

        }

    }
}