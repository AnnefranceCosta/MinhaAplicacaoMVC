using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAplicacaoMvc.Data;
using MinhaAplicacaoMvc.Models;

namespace MinhaAplicacaoMvc.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await _context.Clientes.Include(c => c.Produto).ToListAsync();
            return View(clientes);
        }

        public IActionResult Create()
        {
            ViewBag.Produtos = _context.Produtos
                .Where(p => p.Situacao)
                .ToList();

            ViewBag.Vendedores = new List<string> { "Carlos", "Mariana", "Ana Paula" };

            return View("CreateOrEdit", new Cliente());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Produtos = _context.Produtos.Where(p => p.Situacao).ToList();
            ViewBag.Vendedores = new List<string> { "Carlos", "Mariana", "Ana Paula" };

            return View("CreateOrEdit", cliente); 
        }


        public async Task<IActionResult> Edit(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null) return NotFound();

            ViewBag.Produtos = _context.Produtos.Where(p => p.Situacao).ToList();
            ViewBag.Vendedores = new List<string> { "Carlos", "Mariana", "Ana Paula" };

            return View("CreateOrEdit", cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
