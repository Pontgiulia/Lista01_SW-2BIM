using System;
using System.Collections.Generic;

namespace Exercicio_10
{
    class Program
    {
        // Lista para armazenar os animais
        static List<Animal> animais = new List<Animal>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Animal");
                Console.WriteLine("2. Remover Animal");
                Console.WriteLine("3. Ver Lista de Animais");
                Console.WriteLine("4. Emitir Som de um Animal");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarAnimal();
                            break;
                        case 2:
                            RemoverAnimal();
                            break;
                        case 3:
                            VerAnimais();
                            break;
                        case 4:
                            EmitirSomAnimal();
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
            }
        }

        // Método para adicionar um animal à lista
        static void AdicionarAnimal()
        {
            Console.Write("Nome do Animal: ");
            string nome = Console.ReadLine();
            Console.Write("Espécie do Animal: ");
            string especie = Console.ReadLine();
            Console.Write("Idade do Animal: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                animais.Add(new Animal(nome, especie, idade));
                Console.WriteLine("Animal adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }
        }

        // Método para remover um animal da lista
        static void RemoverAnimal()
        {
            Console.Write("Nome do Animal a ser removido: ");
            string nome = Console.ReadLine();
            Animal animal = animais.Find(a => a.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                animais.Remove(animal);
                Console.WriteLine("Animal removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Animal não encontrado.");
            }
        }

        // Método para exibir a lista de animais
        static void VerAnimais()
        {
            Console.WriteLine("Lista de Animais:");
            foreach (Animal animal in animais)
            {
                Console.WriteLine(animal);
            }
        }

        // Método para emitir o som de um animal
        static void EmitirSomAnimal()
        {
            Console.Write("Nome do Animal: ");
            string nome = Console.ReadLine();
            Animal animal = animais.Find(a => a.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                animal.EmitirSom();
            }
            else
            {
                Console.WriteLine("Animal não encontrado.");
            }
        }
    }

}
