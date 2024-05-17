using System;
using System.Collections.Generic;

namespace Exercicio_12
{

    public class Agenda
    {
        private List<(string Nome, int Idade, float Altura)> pessoas;

        // Construtor padrão para inicializar a lista de pessoas
        public Agenda()
        {
            pessoas = new List<(string, int, float)>();
        }

        // Método para armazenar uma pessoa na agenda
        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            pessoas.Add((nome, idade, altura));
        }

        // Método para remover uma pessoa da agenda pelo nome
        public void RemovePessoa(string nome)
        {
            (string Nome, int Idade, float Altura) pessoa = BuscaPessoa(nome);
            if (pessoa.Nome != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine($"Pessoa {nome} removida da agenda.");
            }
            else
            {
                Console.WriteLine($"Pessoa {nome} não encontrada na agenda.");
            }
        }

        // Método para buscar uma pessoa na agenda pelo nome
        public (string Nome, int Idade, float Altura) BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        // Método para imprimir os dados de todas as pessoas da agenda
        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}m");
            }
        }
    }

}
