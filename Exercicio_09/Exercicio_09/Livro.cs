using System;

namespace Exercicio_09
{
    public class Livro
    {
        private string titulo;
        private string autor;

        // Propriedade Titulo com encapsulamento para garantir que não seja vazia
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O título do livro não pode ser vazio.");
                titulo = value;
            }
        }

        // Propriedade Autor com encapsulamento para garantir que não seja vazia
        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O autor do livro não pode ser vazio.");
                autor = value;
            }
        }

        // Construtor da classe Livro
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        // Sobrescreve o método ToString para exibir as informações do livro
        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}";
        }
    }

}
