namespace BibliotecaWeb.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Capa { get; set; }
        public string? Resumo { get; set; }
        public string? AnoPublicacao { get; set; }
        public Autor? Autor { get; set; }
    }
}