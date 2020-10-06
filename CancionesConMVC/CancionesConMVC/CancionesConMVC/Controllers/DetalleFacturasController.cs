using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CancionesConMVC.Models;

namespace CancionesConMVC.Controllers
{
    public class DetalleFacturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DetalleFacturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DetalleFacturas
        public IActionResult Index(int pagina = 1)
        {
            var totalDeRegistros = _context.DetalleFacturas.Count();

            var detallesFacturas = _context.DetalleFacturas
                .Include(detalleFactura => detalleFactura.Factura)
                .Include(detalleFactura => detalleFactura.Cancion)
                .OrderBy(detalleFactura => detalleFactura.DetFacturaId)
                .Skip((pagina - 1) * 5)
                .Take(5)
                .ToList();

            var totalPaginas = (int)Math.Ceiling((double)totalDeRegistros / 5);

            var paginador = new PaginadorGenerico<DetalleFactura>()
            {
                RegistrosPorPagina = 5,
                TotalRegistros = totalDeRegistros,
                TotalPaginas = totalPaginas,
                PaginaActual = pagina,
                Resultado = detallesFacturas
            };

            return View(paginador);
        }

        // GET: DetalleFacturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleFactura = await _context.DetalleFacturas
                .Include(d => d.Cancion)
                .Include(d => d.Factura)
                .FirstOrDefaultAsync(m => m.DetFacturaId == id);
            if (detalleFactura == null)
            {
                return NotFound();
            }

            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Create
        public IActionResult Create()
        {
            ViewData["CancionId"] = new SelectList(_context.Canciones, "CancionId", "CancionId");
            ViewData["FacturaId"] = new SelectList(_context.Facturas, "FacturaId", "FacturaId");
            return View();
        }

        // POST: DetalleFacturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetFacturaId,FacturaId,CancionId,PrecioUnidad,Cantidad")] DetalleFactura detalleFactura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleFactura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CancionId"] = new SelectList(_context.Canciones, "CancionId", "CancionId", detalleFactura.CancionId);
            ViewData["FacturaId"] = new SelectList(_context.Facturas, "FacturaId", "FacturaId", detalleFactura.FacturaId);
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);
            if (detalleFactura == null)
            {
                return NotFound();
            }
            ViewData["CancionId"] = new SelectList(_context.Canciones, "CancionId", "CancionId", detalleFactura.CancionId);
            ViewData["FacturaId"] = new SelectList(_context.Facturas, "FacturaId", "FacturaId", detalleFactura.FacturaId);
            return View(detalleFactura);
        }

        // POST: DetalleFacturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DetFacturaId,FacturaId,CancionId,PrecioUnidad,Cantidad")] DetalleFactura detalleFactura)
        {
            if (id != detalleFactura.DetFacturaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleFactura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleFacturaExists(detalleFactura.DetFacturaId))
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
            ViewData["CancionId"] = new SelectList(_context.Canciones, "CancionId", "CancionId", detalleFactura.CancionId);
            ViewData["FacturaId"] = new SelectList(_context.Facturas, "FacturaId", "FacturaId", detalleFactura.FacturaId);
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleFactura = await _context.DetalleFacturas
                .Include(d => d.Cancion)
                .Include(d => d.Factura)
                .FirstOrDefaultAsync(m => m.DetFacturaId == id);
            if (detalleFactura == null)
            {
                return NotFound();
            }

            return View(detalleFactura);
        }

        // POST: DetalleFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);
            _context.DetalleFacturas.Remove(detalleFactura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleFacturaExists(int id)
        {
            return _context.DetalleFacturas.Any(e => e.DetFacturaId == id);
        }
    }
}
