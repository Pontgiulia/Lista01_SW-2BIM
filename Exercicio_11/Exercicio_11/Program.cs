using System;
using System.Collections.Generic;

namespace Exercicio_11
{
    

    class Program
    {
        static List<Carro> carros = new List<Carro>(); // Lista para armazenar os carros

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Carro");
                Console.WriteLine("2. Remover Carro");
                Console.WriteLine("3. Ver Lista de Carros");
                Console.WriteLine("4. Acelerar Carro");
                Console.WriteLine("5. Frear Carro");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarCarro();
                            break;
                        case 2:
                            RemoverCarro();
                            break;
                        case 3:
                            VerCarros();
                            break;
                        case 4:
                            AcelerarCarro();
                            break;
                        case 5:
                            FrearCarro();
                            break;
                        case 6:
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

        // Método para adicionar um carro à lista
        static void AdicionarCarro()
        {
            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano do Carro: ");
            if (int.TryParse(Console.ReadLine(), out int ano))
            {
                carros.Add(new Carro(modelo, ano));
                Console.WriteLine("Carro adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Ano inválido.");
            }
        }

        // Método para remover um carro da lista
        static void RemoverCarro()
        {
            Console.Write("Modelo do Carro a ser removido: ");
            string modelo = Console.ReadLine();
            Carro carro = carros.Find(c => c.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
            if (carro != null)
            {
                carros.Remove(carro);
                Console.WriteLine("Carro removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Carro não encontrado.");
            }
        }

        // Método para exibir a lista de carros
        static void VerCarros()
        {
            Console.WriteLine("Lista de Carros:");
            foreach (Carro carro in carros)
            {
                Console.WriteLine(carro);
            }
        }

        // Método para acelerar um carro da lista
        static void AcelerarCarro()
        {
            Console.Write("Modelo do Carro a ser acelerado: ");
            string modelo = Console.ReadLine();
            Carro carro = carros.Find(c => c.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
            if (carro != null)
            {
                carro.Acelerar();
                Console.WriteLine($"O carro {carro.Modelo} foi acelerado para {carro.Velocidade} km/h.");
            }
            else
            {
                Console.WriteLine("Carro não encontrado.");
            }
        }

        // Método para frear um carro da lista
        static void FrearCarro()
        {
            Console.Write("Modelo do Carro a ser freado: ");
            string modelo = Console.ReadLine();
            Carro carro = carros.Find(c => c.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
            if (carro != null)
            {
                carro.Frear();
                Console.WriteLine($"O carro {carro.Modelo} foi freado para {carro.Velocidade} km/h.");
            }
            else
            {
                Console.WriteLine("Carro não encontrado.");
            }
        }
    }

}
