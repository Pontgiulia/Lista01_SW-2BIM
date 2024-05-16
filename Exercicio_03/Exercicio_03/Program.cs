using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        CorretoraDeImóveis corretora = new CorretoraDeImóveis();
        bool continuar = true; //isso aqui é pra repetir várias vezes o negócio de escolher, por isso tá verdadeiro, o 5 tá falso pq é pra parar.

        while (continuar)
        {
            //essas são as opções
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Inserir imóvel");
            Console.WriteLine("2. Alterar preço do imóvel");
            Console.WriteLine("3. Apresentar todos os imóveis");
            Console.WriteLine("4. Calcular valor médio dos imóveis");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                //cada número é um desses casos aqui
                switch (opcao)
                {
                    case 1:
                        Console.Write("Endereço: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço: ");
                        decimal preco;
                        if (decimal.TryParse(Console.ReadLine(), out preco))
                        {
                            Console.Write("Tipo: ");
                            string tipo = Console.ReadLine();
                            corretora.InserirImovel(new Imovel(endereco, preco, tipo));
                        }
                        else
                        {
                            Console.WriteLine("Preço inválido.");
                        }
                        break;
                    case 2:
                        Console.Write("Endereço do imóvel a alterar: ");
                        string enderecoParaAlterar = Console.ReadLine();
                        Console.Write("Novo preço: ");
                        decimal novoPreco;
                        if (decimal.TryParse(Console.ReadLine(), out novoPreco))
                        {
                            corretora.AlterarPrecoImovel(enderecoParaAlterar, novoPreco);
                        }
                        else
                        {
                            Console.WriteLine("Preço inválido.");
                        }
                        break;
                    case 3:
                        List<Imovel> imoveis = corretora.ListarImoveis();
                        foreach (Imovel imovel in imoveis)
                        {
                            Console.WriteLine(imovel);
                        }
                        break;
                    case 4:
                        decimal valorMedio = corretora.CalcularValorMedio();
                        Console.WriteLine($"Valor médio dos imóveis: {valorMedio:C}");
                        break;
                    case 5:
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
            Console.WriteLine();
        }
    }
}
