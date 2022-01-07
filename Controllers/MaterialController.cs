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
            ViewData["materiales"] = from o in _context.Material select o;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Material objMaterial)
        {
            _context.Add(objMaterial);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, string nombre)
        {
            var mat = new Material();
            mat = await _context.Material.FindAsync(id);
            mat.NomMaterial = nombre;
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mater = await _context.Material.FindAsync(id);
            if (mater == null)
            {
                return NotFound();
            }

            return View(mater);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mater = await _context.Material.FindAsync(id);
            _context.Material.Remove(mater);
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