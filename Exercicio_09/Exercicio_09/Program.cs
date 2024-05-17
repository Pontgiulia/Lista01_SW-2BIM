using System;
using System.Collections.Generic;

namespace Exercicio_09
{

    class Program
    {
        // Lista para armazenar os livros
        static List<Livro> livros = new List<Livro>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Remover Livro");
                Console.WriteLine("3. Ver Lista de Livros");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarLivro();
                            break;
                        case 2:
                            RemoverLivro();
                            break;
                        case 3:
                            VerLivros();
                            break;
                        case 4:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
        }

        // Método para adicionar um livro à lista
        static void AdicionarLivro()
        {
            Console.Write("Título do Livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor do Livro: ");
            string autor = Console.ReadLine();
            try
            {
                livros.Add(new Livro(titulo, autor));
                Console.WriteLine("Livro adicionado com sucesso.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        // Método para remover um livro da lista
        static void RemoverLivro()
        {
            Console.Write("Título do Livro a ser removido: ");
            string titulo = Console.ReadLine();
            Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null)
            {
                livros.Remove(livro);
                Console.WriteLine("Livro removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        // Método para exibir a lista de livros
        static void VerLivros()
        {
            Console.WriteLine("Lista de Livros:");
            foreach (Livro livro in livros)
            {
                Console.WriteLine(livro);
            }
        }
    }

}
