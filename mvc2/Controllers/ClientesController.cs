using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using mvc2.Data;
using mvc2.Models;

namespace MvcMovie.Controllers;

public class ClientesController : Controller
{
    private readonly BancoContext _context;
    public ClientesController(BancoContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {   
        var clientes = _context.Cliente.ToList();
        
        ViewData["clientes"] = clientes;

        return View();
    }

    public IActionResult Editar(int id)
    {   
        var cliente = _context.Cliente.FirstOrDefault(c => c.CLI_CODIGON == id);
        return View(cliente);
    }

    public IActionResult Criar()
    {   
        
        return View();
    }

    public async Task<IActionResult> Create(ClienteModel cliente)
    {
        if (ModelState.IsValid)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        return View(cliente);
    }

    public async Task<IActionResult> Update(int id, ClienteModel cliente)
    {
        Console.WriteLine(id);

        if (ModelState.IsValid)
        {
            Console.WriteLine(id);
            var existingCliente = await _context.Cliente.FindAsync(id);

            existingCliente.CLI_NOME = cliente.CLI_NOME;
            existingCliente.CLI_CGC = cliente.CLI_CGC;

            _context.Update(existingCliente);
            await _context.SaveChangesAsync();
            

            return RedirectToAction(nameof(Index));
        }

        return View(cliente);
    }
}