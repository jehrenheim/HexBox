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
            return View(products);
        }

        public IActionResult Shop(int ID)
        {
            ViewData["Message"] = "Your application description page.";

            return View();
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
