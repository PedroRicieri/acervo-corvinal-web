namespace BibliotecaWeb.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? DataNascimento { get; set; } 
        public string? Foto { get; set; }
        public string? Biografia { get; set; }
        public List<Livro> LivrosRelacionados { get; set; } = new List<Livro>();
    }
}