using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    public class VentasController : Controller
    {
        private readonly TiendaContext _context;

        public VentasController(TiendaContext context)
        {
            _context = context;
        }

        //mostrar la vista principal con las categorias filtradas
        public IActionResult Index()
        {
            var categorias = _context.Categoria
                .Where(c => c.Producto.Any(p => p.Ventas.Any(v => v.Fecha.Year == 2019)))
                .ToList();
            ViewBag.Categorias = categorias;
            return View();
        }

        //filtrar productos vendidos en una categoria especifica
        [HttpPost]
        public IActionResult Filtrar(int categoriaId)
        {
            var productosVendidos = _context.Producto
                .Where(p => p.CodigoCategoria == categoriaId && p.Ventas.Any(v => v.Fecha.Year == 2019))
                .Select(p => p.Nombre)
                .ToList();
            return Json(productosVendidos);
        }
    }
}
