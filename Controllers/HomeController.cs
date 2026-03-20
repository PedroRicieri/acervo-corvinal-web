using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BibliotecaWeb.Models;
using System.Linq;

namespace BibliotecaWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
       
        var livrosDestaque = Dados.Livros.ToList(); 
        
        ViewData["NomeBiblioteca"] = "Biblioteca Acervo Corvinal";
        ViewData["Descricao"] = "Bem-vindo ao nosso acervo. 'O espírito sem limites é o maior tesouro do homem.'";

        return View(livrosDestaque);
    }

    // Lógica da Barra de Pesquisa (Lupa)
    public IActionResult Buscar(string termo)
    {
        // Se a pessoa pesquisar vazio, volta pra página inicial
        if (string.IsNullOrWhiteSpace(termo)) 
            return RedirectToAction("Index");

        // Pesquisando por nome (ignorando maiúsculas e minúsculas)
        // Pesquisando por nome (ignorando maiúsculas e minúsculas e garantindo que não são nulos)
        var livrosEncontrados = Dados.Livros
            .Where(l => l.Titulo != null && l.Titulo.Contains(termo, StringComparison.OrdinalIgnoreCase))
            .ToList();
            
        var autoresEncontrados = Dados.Autores
            .Where(a => a.Nome != null && a.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase))
            .ToList();

        ViewData["Termo"] = termo;
        ViewBag.Autores = autoresEncontrados; // Enviamos a lista de autores via ViewBag

        // Retorna para a tela de resultados
        return View("Buscar", livrosEncontrados);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}