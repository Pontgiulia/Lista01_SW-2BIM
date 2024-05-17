using System;

public class Fabricante
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }

    public Fabricante(string nome, string endereco, string cidade)
    {
        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Endereço: {Endereco}, Cidade: {Cidade}";
    }
}
