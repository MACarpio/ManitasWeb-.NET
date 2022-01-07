using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManitasWeb.Models;
using ManitasWeb.Data;
using System.Diagnostics;
using System.Dynamic;

namespace ManitasWeb.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public CatalogoController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

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

        public async Task<IActionResult> Details(int? id)
        {
            Producto objProduct = await _context.Producto
            .Include(p => p.Mater)
            .Include(p => p.Categ)
            .FirstOrDefaultAsync(i => i.Id == id);
            if (objProduct == null)
            {
                return NotFound();
            }
            return View(objProduct);
        }
        public IActionResult MostrarImagen(int id)
        {
            var producto = _context.Producto.Find(id);
            byte[] imagen = producto.Imagen;
            return File(imagen, "images/png");
        }
        public IActionResult MostrarImagenCat(int id)
        {
            var producto = _context.Categoria.Find(id);
            byte[] imagen = producto.Imagen;
            return File(imagen, "images/png");
        }
        public IActionResult ObtenerMaterial()
        {
            var mat = _context.Material.ToListAsync();

            return View(mat);
        }

    }
}