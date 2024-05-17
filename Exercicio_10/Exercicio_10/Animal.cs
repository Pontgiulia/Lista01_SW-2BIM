using System;

namespace Exercicio_10
{
    public class Animal
    {
        // Propriedades com encapsulamento para armazenar os dados do animal
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        // Construtor da classe Animal
        // Inicializa as propriedades Nome, Especie e Idade
        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        // Método que imprime o som do animal na tela
        public void EmitirSom()
        {
            // Aqui apenas um exemplo genérico, pode ser personalizado por espécie
            Console.WriteLine($"{Nome}, o {Especie}, emite um som!");
        }

        // Sobrescreve o método ToString para exibir as informações do animal
        public override string ToString()
        {
            return $"Nome: {Nome}, Espécie: {Especie}, Idade: {Idade}";
        }
    }

}
