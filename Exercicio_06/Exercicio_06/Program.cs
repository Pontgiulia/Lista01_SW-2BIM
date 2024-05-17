using System;
using System.Collections.Generic;

namespace Exercicio_06
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static int proximoIndice = 1;

        static void Main(string[] args)
        {
            // Adicionando alguns produtos à lista
            produtos.Add(new Produto("Camiseta", 29.99m, 50, proximoIndice++));
            produtos.Add(new Produto("Calça Jeans", 59.99m, 30, proximoIndice++));
            produtos.Add(new Produto("Tênis", 99.99m, 20, proximoIndice++));

            // Exibindo menu
            ExibirMenu();
        }

        static void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Produto ao Estoque");
                Console.WriteLine("2. Remover Produto do Estoque");
                Console.WriteLine("3. Consultar Produto pelo Código");
                Console.WriteLine("4. Exibir Lista de Produtos");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarProduto();
                            break;
                        case 2:
                            RemoverProduto();
                            break;
                        case 3:
                            ConsultarProduto();
                            break;
                        case 4:
                            ExibirListaProdutos();
                            break;
                        case 5:
                            Console.WriteLine("Saindo...");
                            return;
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

        static void AdicionarProduto()
        {
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal preco))
            {
                Console.Write("Quantidade em Estoque: ");
                if (int.TryParse(Console.ReadLine(), out int quantidade))
                {
                    Console.Write("Código do Produto: ");
                    if (int.TryParse(Console.ReadLine(), out int codigo))
                    {
                        produtos.Add(new Produto(nome, preco, quantidade, codigo));
                        Console.WriteLine("Produto adicionado ao estoque com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Quantidade inválida.");
                }
            }
            else
            {
                Console.WriteLine("Preço inválido.");
            }
        }


        static void RemoverProduto()
        {
            Console.Write("Código do Produto a ser removido: ");
            if (int.TryParse(Console.ReadLine(), out int cod))
            {
                Produto produto = produtos.Find(p => p.Indice == cod);
                if (produto != null)
                {
                    produtos.Remove(produto);
                    Console.WriteLine("Produto removido do estoque.");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }
        }

        static void ConsultarProduto()
        {
            Console.Write("Código do Produto a ser consultado: ");
            if (int.TryParse(Console.ReadLine(), out int cod))
            {
                Produto produto = produtos.Find(p => p.Indice == cod);
                if (produto != null)
                {
                    produto.ExibirInformacoes();
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }
        }

        static void ExibirListaProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                produto.ExibirInformacoes();
            }
        }
    }
}