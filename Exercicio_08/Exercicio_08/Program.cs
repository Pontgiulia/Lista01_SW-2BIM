using System;
using System.Collections.Generic;

namespace Exercicio_08
{

    class Program
    {
        static List<Fabricante> fabricantes = new List<Fabricante>();
        static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Fabricante");
                Console.WriteLine("2. Remover Fabricante");
                Console.WriteLine("3. Ver Fabricantes");
                Console.WriteLine("4. Adicionar Produto");
                Console.WriteLine("5. Remover Produto");
                Console.WriteLine("6. Ver Produtos");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarFabricante();
                            break;
                        case 2:
                            RemoverFabricante();
                            break;
                        case 3:
                            VerFabricantes();
                            break;
                        case 4:
                            AdicionarProduto();
                            break;
                        case 5:
                            RemoverProduto();
                            break;
                        case 6:
                            VerProdutos();
                            break;
                        case 7:
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

        static void AdicionarFabricante()
        {
            Console.Write("Nome do Fabricante: ");
            string nome = Console.ReadLine();
            Console.Write("Endereço do Fabricante: ");
            string endereco = Console.ReadLine();
            Console.Write("Cidade do Fabricante: ");
            string cidade = Console.ReadLine();
            fabricantes.Add(new Fabricante(nome, endereco, cidade));
            Console.WriteLine("Fabricante adicionado com sucesso.");
        }

        static void RemoverFabricante()
        {
            Console.Write("Nome do Fabricante a ser removido: ");
            string nome = Console.ReadLine();
            Fabricante fabricante = fabricantes.Find(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (fabricante != null)
            {
                fabricantes.Remove(fabricante);
                Console.WriteLine("Fabricante removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Fabricante não encontrado.");
            }
        }

        static void VerFabricantes()
        {
            Console.WriteLine("Lista de Fabricantes:");
            foreach (Fabricante fabricante in fabricantes)
            {
                Console.WriteLine(fabricante);
            }
        }

        static void AdicionarProduto()
        {
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal preco))
            {
                Console.Write("Nome do Fabricante: ");
                string nomeFabricante = Console.ReadLine();
                Fabricante fabricante = fabricantes.Find(f => f.Nome.Equals(nomeFabricante, StringComparison.OrdinalIgnoreCase));
                if (fabricante != null)
                {
                    produtos.Add(new Produto(nome, fabricante, preco));
                    Console.WriteLine("Produto adicionado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Fabricante não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Preço inválido.");
            }
        }

        static void RemoverProduto()
        {
            Console.Write("Nome do Produto a ser removido: ");
            string nome = Console.ReadLine();
            Produto produto = produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void VerProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }

}
