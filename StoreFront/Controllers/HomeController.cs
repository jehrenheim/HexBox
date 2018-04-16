using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreFront.Models;

namespace StoreFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreContext _context;

        public HomeController(StoreContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.Product.Include(product => product.Category).ToListAsync();

            var categories = _context.Category.OrderBy(x => x.Name).ToList();

            ViewData["Categories"] = categories;

            return View(products);
        }

        public async Task<IActionResult> Shop(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.Include(p => p.Images).Include(p => p.Category).SingleOrDefaultAsync(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            product.Images = product.Images.OrderBy(x => x.Place).ToList();
            var relatedProduct = _context.Product.Where(x => x.CategoryId == product.CategoryId).Where(x => x.ID != product.ID).FirstOrDefault();
            if (relatedProduct == null)
            {
                ViewData["related"] = false;
            }
            else
            {
                ViewData["related"] = true;
                product.RelatedProduct = relatedProduct;
            }

            return View(product);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
