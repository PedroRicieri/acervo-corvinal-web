using Microsoft.AspNetCore.Mvc;
using BibliotecaWeb.Models;
using System.Linq;

namespace BibliotecaWeb.Controllers;

public class LivroController : Controller
{
    // NOVO: Rota para mostrar TODOS os livros
    public IActionResult Index()
    {
        var todosOsLivros = Dados.Livros.ToList();
        return View(todosOsLivros);
    }

    // Rota que já existia
    public IActionResult Detalhes(int id)
    {
        var livro = Dados.Livros.FirstOrDefault(l => l.Id == id);
        if (livro == null) return NotFound();
        return View(livro);
    }
}