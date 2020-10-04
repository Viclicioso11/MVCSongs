using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CancionesConMVC.Models;

namespace CancionesConMVC.Controllers
{
    public class ArtistasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Artistas
        public async Task<IActionResult> Index(int pagina = 1)
        {
            var totalDeRegistros = _context.Artistas.Count();

            var artistas = _context.Artistas
                .OrderBy(artista => artista.Nombre)
                .Skip((pagina - 1) * 5)
                .Take(5)
                .ToList();

            var totalPaginas = (int)Math.Ceiling((double)totalDeRegistros / 5);

            var paginador = new PaginadorGenerico<Artista>()
            {
                RegistrosPorPagina = 5,
                TotalRegistros = totalDeRegistros,
                TotalPaginas = totalPaginas,
                PaginaActual = pagina,
                Resultado = artistas
            };

            return View(paginador);
        }

        // GET: Artistas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artista = await _context.Artistas
                .FirstOrDefaultAsync(m => m.ArtistaId == id);
            if (artista == null)
            {
                return NotFound();
            }

            return View(artista);
        }

        // GET: Artistas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artistas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtistaId,Nombre")] Artista artista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artista);
        }

        // GET: Artistas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artista = await _context.Artistas.FindAsync(id);
            if (artista == null)
            {
                return NotFound();
            }
            return View(artista);
        }

        // POST: Artistas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtistaId,Nombre")] Artista artista)
        {
            if (id != artista.ArtistaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistaExists(artista.ArtistaId))
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
            return View(artista);
        }

        // GET: Artistas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artista = await _context.Artistas
                .FirstOrDefaultAsync(m => m.ArtistaId == id);
            if (artista == null)
            {
                return NotFound();
            }

            return View(artista);
        }

        // POST: Artistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artista = await _context.Artistas.FindAsync(id);
            _context.Artistas.Remove(artista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistaExists(int id)
        {
            return _context.Artistas.Any(e => e.ArtistaId == id);
        }
    }
}
