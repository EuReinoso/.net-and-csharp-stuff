using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class ClientesController : Controller
{
    public IActionResult Index()
    {   
        List<String> clientesLista = new List<string>() {"Lucas", "João", "claudia"};
        @ViewData["Clientes"] = clientesLista;

        return View();
    }
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}