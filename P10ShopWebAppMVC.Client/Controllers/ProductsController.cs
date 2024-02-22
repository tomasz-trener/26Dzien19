using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using P10ShopWebAppMVC.Client.Models;

namespace P10ShopWebAppMVC.Client.Controllers
{
    public class ProductsController : Controller
    {
        //private readonly ShopContext _context;

        //public ProductsController(/*ShopContext context*/)
        //{
        //    _context = context;
        //}

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: Products
        public async Task<IActionResult> Index()
        {
            var prodcuts = await _productService.GetProductsAsync();
            return prodcuts != null ?
                View(prodcuts.Data.AsEnumerable()) :
                Problem("Products data is null");


           // return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetProductAsync((int)id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product.Data);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Barcode,Price,ReleaseDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProductAsync(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productServiceReposnse = await _productService.GetProductAsync((int)id);
            if (productServiceReposnse == null || !productServiceReposnse.Success)
            {
                return NotFound();
            }
            return View(productServiceReposnse.Data);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Barcode,Price,ReleaseDate")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   var productResult = await _productService.UpdateProductAsync(product);
                  
                }
                catch (Exception)
                {
                    return NotFound();
                  
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productServiceReposnse = await _productService.GetProductAsync((int)id);
            if (productServiceReposnse == null || !productServiceReposnse.Success)
            {
                return NotFound();
            }

            return View(productServiceReposnse.Data);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productServiceReposnse = await _productService.DeleteProductAsync((int)id);
            if (productServiceReposnse != null && productServiceReposnse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }

            
            
        }

 
    }
}
