using System;
using System.Collections.Generic;

public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }
    public int Indice { get; private set; }

    // Construtor da classe Produto
    public Produto(string nome, decimal preco, int quantidadeEmEstoque, int indice)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
        Indice = indice;
    }

    // Método para adicionar itens ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEmEstoque += quantidade;
        Console.WriteLine($"{quantidade} unidades do produto {Nome} adicionadas ao estoque.");
    }

    // Método para remover itens do estoque
    public void RemoverEstoque(int quantidade)
    {
        if (QuantidadeEmEstoque >= quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades do produto {Nome} removidas do estoque.");
        }
        else
        {
            Console.WriteLine($"Não há {quantidade} unidades do produto {Nome} disponíveis no estoque.");
        }
    }

    // Método para exibir informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Índice: {Indice}, Nome: {Nome}, Preço: {Preco}, Quantidade em Estoque: {QuantidadeEmEstoque}");
    }
}


