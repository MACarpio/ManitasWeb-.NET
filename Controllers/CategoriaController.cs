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
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Index()
        {
            ViewData["categorias"] = from o in _context.Categoria select o;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["categorias"] = from o in _context.Categoria select o;
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
                return RedirectToAction(nameof(Create));
            }
            return View(categoria);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categ = await _context.Categoria.FindAsync(id);
            if (categ == null)
            {
                return NotFound();
            }
            return View(categ);
        }

        // POST: categoria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Categoria categoria, List<IFormFile> upload)
        {
            if (id != categoria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (upload == null || upload.Count <= 0)
                {
                    byte[] imagen = categoria.Imagen;
                    categoria.Imagen = imagen;
                }
                else
                {
                    foreach (var up in upload)
                    {
                        Stream str = up.OpenReadStream();
                        BinaryReader br = new BinaryReader(str);
                        Byte[] fileDet = br.ReadBytes((Int32)str.Length);
                        categoria.Imagen = fileDet;
                    }
                }
                _context.Update(categoria);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Create));
            }
            return View(categoria);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categ = await _context.Categoria.FindAsync(id);
            if (categ == null)
            {
                return NotFound();
            }

            return View(categ);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mater = await _context.Categoria.FindAsync(id);
            _context.Categoria.Remove(mater);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }
    }
}