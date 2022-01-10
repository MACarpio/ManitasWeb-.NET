using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManitasWeb.Data;
using ManitasWeb.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Dynamic;

namespace ManitasWeb.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Product
        [HttpGet]
        public async Task<IActionResult> Index(int Cat, int Mat)
        {
            var empquery = from x in _context.Producto select x;
            if (Cat != 0)
            {
                empquery = empquery.Where(x => x.Categ.Id == Cat);
            }
            if (Mat != 0)
            {
                empquery = empquery.Where(x => x.Mater.Id == Mat);
            }
            var productos = await empquery.ToListAsync();
            dynamic model = new ExpandoObject();
            model.prod = productos;
            var materiales = await _context.Material.ToListAsync();
            var categorias = await _context.Categoria.ToListAsync();
            model.mate = materiales;
            model.cate = categorias;

            return View(model);
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Producto
            .Include(p => p.Mater)
            .Include(p => p.Categ)
            .FirstOrDefaultAsync(i => i.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create

        public IActionResult Create()
        {
            ViewData["materiales"] = from o in _context.Material select o;
            ViewData["categorias"] = from x in _context.Categoria select x;
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(Producto product, List<IFormFile> upload, int? categori, int? materia)
        {
            if (ModelState.IsValid)
            {
                if (upload.Count > 0)
                {

                    foreach (var up in upload)
                    {
                        Stream str = up.OpenReadStream();
                        BinaryReader br = new BinaryReader(str);
                        Byte[] fileDet = br.ReadBytes((Int32)str.Length);
                        product.Imagen = fileDet;
                        product.ImagenNom = Path.GetFileName(up.FileName);
                    }
                }
                var materiales = new Material();
                materiales = await _context.Material.FindAsync(materia);
                _context.Material.Attach(materiales);
                var categorias = new Categoria();
                categorias = await _context.Categoria.FindAsync(categori);
                _context.Categoria.Attach(categorias);
                product.Categ = categorias;
                product.Mater = materiales;
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["materiales"] = from o in _context.Material select o;
            ViewData["categorias"] = from x in _context.Categoria select x;
            var product = await _context.Producto.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producto product, List<IFormFile> upload, int? categori, int? materia)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (upload == null || upload.Count <= 0)
                    {
                        byte[] imagen = product.Imagen;
                        var nom = product.ImagenNom;
                        product.Imagen = imagen;
                        product.ImagenNom = nom;
                    }
                    else
                    {
                        foreach (var up in upload)
                        {
                            Stream str = up.OpenReadStream();
                            BinaryReader br = new BinaryReader(str);
                            Byte[] fileDet = br.ReadBytes((Int32)str.Length);
                            product.Imagen = fileDet;
                            product.ImagenNom = Path.GetFileName(up.FileName);
                        }
                    }
                    if (materia != 99999)
                    {
                        var materiales = new Material();
                        materiales = await _context.Material.FindAsync(materia);
                        _context.Material.Attach(materiales);
                        product.Mater = materiales;
                    }

                    if (categori != 99999)
                    {
                        var categorias = new Categoria();
                        categorias = await _context.Categoria.FindAsync(categori);
                        _context.Categoria.Attach(categorias);
                        product.Categ = categorias;
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Producto product = await _context.Producto
            .Include(p => p.Mater)
            .Include(p => p.Categ)
            .FirstOrDefaultAsync(i => i.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
        public IActionResult MostrarImagen(int id)
        {
            var producto = _context.Producto.Find(id);
            byte[] imagen = producto.Imagen;
            return File(imagen, "img/png");
        }

    }
}
