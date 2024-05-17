using System;
public class Produto
{
    private string nome;
    private decimal preco;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do produto não pode ser vazio.");
            nome = value;
        }
    }

    public Fabricante Fabricante { get; set; }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("O preço do produto deve ser positivo.");
            preco = value;
        }
    }

    public Produto(string nome, Fabricante fabricante, decimal preco)
    {
        Nome = nome;
        Fabricante = fabricante;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Fabricante: {Fabricante.Nome}, Preço: {Preco:C}";
    }
}

