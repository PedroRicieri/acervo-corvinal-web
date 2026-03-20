using Microsoft.AspNetCore.Mvc;
using BibliotecaWeb.Models;
using System.Linq;

namespace BibliotecaWeb.Controllers;

public class AutorController : Controller
{
    // NOVO: Rota para mostrar TODOS os autores
    public IActionResult Index()
    {
        var todosOsAutores = Dados.Autores.ToList();
        return View(todosOsAutores);
    }

    // Rota que já existia
    public IActionResult Detalhes(int id)
    {
        var autor = Dados.Autores.FirstOrDefault(a => a.Id == id);
        if (autor == null) return NotFound();
        return View(autor);
    }
}