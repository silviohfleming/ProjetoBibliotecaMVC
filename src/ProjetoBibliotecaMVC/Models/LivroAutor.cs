﻿namespace ProjetoBibliotecaMVC.Models
{
    public class LivroAutor
    {
        public int AutorID { get; set; }
        public Autor Autor { get; set; }

        public int LivroID { get; set; }
        public Livro Livro { get; set; }
    }
}
