using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ManitasWeb.Models;
using ManitasWeb.Data;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace ManitasWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            dynamic model = new ExpandoObject();
            var productos = await _context.Producto.ToListAsync();
            var materiales = await _context.Material.ToListAsync();
            var categorias = await _context.Categoria.ToListAsync();
            model.prod = productos;
            model.mate = materiales;
            model.cate = categorias;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
