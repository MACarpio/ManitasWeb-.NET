using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManitasWeb.Models;
using Microsoft.Extensions.Logging;
using ManitasWeb.Data;

namespace ManitasWeb.Controllers
{
    public class MaterialController : Controller
    {
        private readonly ILogger<MaterialController> _logger;
        private readonly ApplicationDbContext _context;

        public MaterialController(ILogger<MaterialController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Material objMaterial)
        {
            _context.Add(objMaterial);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}