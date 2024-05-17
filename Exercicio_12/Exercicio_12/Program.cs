using System;
using System.Collections.Generic;

namespace Exercicio_12
{

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Nome da Pessoa: ");
                            string nome = Console.ReadLine();
                            Console.Write("Idade da Pessoa: ");
                            int idade = int.Parse(Console.ReadLine());
                            Console.Write("Altura da Pessoa (em metros): ");
                            float altura = float.Parse(Console.ReadLine());
                            agenda.ArmazenaPessoa(nome, idade, altura);
                            Console.WriteLine("Pessoa adicionada com sucesso.");
                            break;
                        case 2:
                            Console.Write("Nome da Pessoa a ser removida: ");
                            string nomeRemover = Console.ReadLine();
                            agenda.RemovePessoa(nomeRemover);
                            break;
                        case 3:
                            Console.Write("Nome da Pessoa a ser buscada: ");
                            string nomeBuscar = Console.ReadLine();
                            (string Nome, int Idade, float Altura) pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                            if (pessoaEncontrada.Nome != null)
                            {
                                Console.WriteLine($"Pessoa encontrada: Nome: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}m");
                            }
                            else
                            {
                                Console.WriteLine("Pessoa não encontrada na agenda.");
                            }
                            break;
                        case 4:
                            agenda.ImprimeAgenda();
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
    }

}
