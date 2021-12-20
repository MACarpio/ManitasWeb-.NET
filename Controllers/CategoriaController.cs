using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManitasWeb.Models;
using Microsoft.Extensions.Logging;
using ManitasWeb.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ManitasWeb.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ILogger<CategoriaController> _logger;
        private readonly ApplicationDbContext _context;

        public CategoriaController(ILogger<CategoriaController> logger,
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
        public async Task<IActionResult> Create(Categoria categoria, List<IFormFile> upload)
        {
            if (ModelState.IsValid)
            {
                foreach (var up in upload)
                {
                    Stream str = up.OpenReadStream();
                    BinaryReader br = new BinaryReader(str);
                    Byte[] fileDet = br.ReadBytes((Int32)str.Length);
                    categoria.Imagen = fileDet;
                }

                _context.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}