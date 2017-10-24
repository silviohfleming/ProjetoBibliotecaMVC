using ProjetoBibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBibliotecaMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Verifica se existe algum livro
            if (context.Livro.Any())
            {
                return;   // Caso exista algum livro... retornar!
            }

            var livros = new Livro[]
            {
                new Livro {Titulo = "Android 6 Para Programadores", Quantidade = 5},
                new Livro {Titulo = "Redes de Computadores e Internet", Quantidade = 8},
                new Livro {Titulo = "Engenharia de Software", Quantidade = 4},
                new Livro {Titulo = "Java para Iniciantes", Quantidade = 3},
                new Livro {Titulo = "Resposta a Incidentes de Segurança em Computadores", Quantidade = 8}
            };

            foreach (Livro l in livros)
            {
                context.Livro.Add(l);
            }

            var autores = new Autor[]
            {
                new Autor { Nome = "Paul J. Deitel" },
                new Autor { Nome = "Harvey M. Deitel"},
                new Autor { Nome = "Douglas E. Comer"},
                new Autor { Nome = "Roger S. Pressman"},
                new Autor { Nome = "Bruce R. Maxim"},
                new Autor { Nome = "Herbert Schildt"},
                new Autor { Nome = "N. K. McCarthy"}
            };

            foreach (Autor a in autores)
            {
                context.Autor.Add(a);
            }

            var usuarios = new Usuario[]
            {
                new Usuario { Nome = "Usuario", Email = "usuario@teste.com", Senha = "teste123" }
            };

            foreach (Usuario a in usuarios)
            {
                context.Usuario.Add(a);
            }

            context.SaveChanges();
        }
    }
}
