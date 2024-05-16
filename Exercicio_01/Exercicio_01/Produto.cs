using System;

class Produto
{
    // Atributos
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }

    // Construtor
    public Produto(string nome, double preco, int quantidadeInicial)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeInicial;
    }

    // Método para adicionar itens ao estoque
    public void AdicionarAoEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} itens de {Nome} adicionados ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
        }
    }

    // Método para remover itens do estoque
    public void RemoverDoEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} itens de {Nome} removidos do estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade inválida ou insuficiente em estoque.");
        }
    }
}


