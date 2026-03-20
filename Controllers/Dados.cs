namespace BibliotecaWeb.Models
{
    public static class Dados
    {
        public static List<Autor> Autores { get; set; } = new List<Autor>();
        public static List<Livro> Livros { get; set; } = new List<Livro>();

        static Dados()
        {
            // --- 1. CADASTRANDO OS AUTORES ---
            var machado = new Autor { Id = 1, Nome = "Machado de Assis", DataNascimento = "21 de junho de 1839", Foto = "/img/machado.jpg", Biografia = "Joaquim Maria Machado de Assis foi um escritor brasileiro, considerado por muitos o maior nome da literatura do Brasil." };
            var orwell = new Autor { Id = 2, Nome = "George Orwell", DataNascimento = "25 de junho de 1903", Foto = "/img/orwell.jpg", Biografia = "Escritor e jornalista inglês, mestre em distopias e críticas sociais." };
            var ramalho = new Autor { Id = 3, Nome = "Luciano Ramalho", DataNascimento = "1962", Foto = "/img/ramalho.jpg", Biografia = "Programador experiente, palestrante internacional e autor de um dos livros mais aclamados sobre a linguagem Python." };
            var kotler = new Autor { Id = 4, Nome = "Philip Kotler", DataNascimento = "27 de maio de 1931", Foto = "/img/kotler.avif", Biografia = "Conhecido como o 'pai do marketing moderno', é um dos maiores especialistas em estratégias de mercado." };
            var uncleBob = new Autor { Id = 5, Nome = "Robert C. Martin", DataNascimento = "5 de dezembro de 1952", Foto = "/img/uncle-bob.jpg", Biografia = "Engenheiro de software e um dos coautores do Manifesto Ágil. Famoso por suas publicações sobre design de código." };
            var tolkien = new Autor { Id = 6, Nome = "J.R.R. Tolkien", DataNascimento = "3 de janeiro de 1892", Foto = "/img/tolkien.jpg", Biografia = "Escritor, professor e filólogo britânico, mundialmente famoso por criar o universo da Terra-média." };
            var rowling = new Autor { Id = 7, Nome = "J.K. Rowling", DataNascimento = "31 de julho de 1965", Foto = "/img/rowling.webp", Biografia = "Escritora britânica e criadora do universo mágico de Harry Potter, uma das séries literárias mais vendidas da história." };

            Autores.AddRange(new[] { machado, orwell, ramalho, kotler, uncleBob, tolkien, rowling });

            // --- 2. CADASTRANDO OS LIVROS ---
            var livro1 = new Livro { Id = 1, Titulo = "Dom Casmurro", Capa = "/img/dom-casmurro.jpg", Resumo = "A clássica e intrigante história de Bento Santiago e Capitu.", AnoPublicacao = "1899", Autor = machado };
            var livro2 = new Livro { Id = 2, Titulo = "O Alienista", Capa = "/img/alienista.jpg", Resumo = "O médico Simão Bacamarte decide internar os loucos de sua cidade, mas os limites da sanidade são testados.", AnoPublicacao = "1882", Autor = machado };
            var livro3 = new Livro { Id = 3, Titulo = "1984", Capa = "/img/1984.jpg", Resumo = "Sob o olhar opressivo do Grande Irmão, Winston Smith tenta resistir a um regime totalitário.", AnoPublicacao = "1949", Autor = orwell };
            var livro4 = new Livro { Id = 4, Titulo = "Python Fluente", Capa = "/img/python-fluente.jpg", Resumo = "Um guia profundo e detalhado para escrever códigos Python claros, concisos e eficientes.", AnoPublicacao = "2015", Autor = ramalho };
            var livro5 = new Livro { Id = 5, Titulo = "Marketing 4.0", Capa = "/img/marketing40.jpg", Resumo = "Do tradicional ao digital: como entender e alcançar o consumidor na era da conectividade.", AnoPublicacao = "2017", Autor = kotler };
            var livro6 = new Livro { Id = 6, Titulo = "Código Limpo (Clean Code)", Capa = "/img/clean-code.jpg", Resumo = "As melhores práticas ágeis de engenharia de software para transformar códigos ruins em sistemas robustos.", AnoPublicacao = "2008", Autor = uncleBob };
            var livro7 = new Livro { Id = 7, Titulo = "A Sociedade do Anel", Capa = "/img/senhor-aneis.jpg", Resumo = "O início da jornada épica de Frodo Bolseiro para destruir o Um Anel e salvar a Terra-média.", AnoPublicacao = "1954", Autor = tolkien };
            
            // NOVOS: Harry Potter
            var livro8 = new Livro { Id = 8, Titulo = "Harry Potter e a Pedra Filosofal", Capa = "/img/pedra-filosofal.jpg", Resumo = "Um garoto órfão descobre que é bruxo e vai estudar na Escola de Magia e Bruxaria de Hogwarts.", AnoPublicacao = "1997", Autor = rowling };
            var livro9 = new Livro { Id = 9, Titulo = "Harry Potter e a Câmara Secreta", Capa = "/img/camara-secreta.jpg", Resumo = "Carros voadores, árvores que lutam e um monstro misterioso solto pelo castelo marcam o segundo ano de Harry.", AnoPublicacao = "1998", Autor = rowling };
            var livro10 = new Livro { Id = 10, Titulo = "Harry Potter e o Prisioneiro de Azkaban", Capa = "/img/prisioneiro-azkaban.jpg", Resumo = "Um perigoso assassino foge da prisão bruxa de Azkaban e parece estar atrás de Harry Potter.", AnoPublicacao = "1999", Autor = rowling };

            Livros.AddRange(new[] { livro1, livro2, livro3, livro4, livro5, livro6, livro7, livro8, livro9, livro10 });

            // --- 3. ASSOCIANDO LIVROS AOS SEUS AUTORES ---
            machado.LivrosRelacionados.AddRange(new[] { livro1, livro2 });
            orwell.LivrosRelacionados.Add(livro3);
            ramalho.LivrosRelacionados.Add(livro4);
            kotler.LivrosRelacionados.Add(livro5);
            uncleBob.LivrosRelacionados.Add(livro6);
            tolkien.LivrosRelacionados.Add(livro7);
            rowling.LivrosRelacionados.AddRange(new[] { livro8, livro9, livro10 });
        }
    }
}