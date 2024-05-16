using System;
using System.Collections.Generic;
using System.Linq;
public class Imovel
{
    //esse define que tipo de dado é cada um
    public string Endereco { get; set; }
    public decimal Preco { get; set; }
    public string Tipo { get; set; }

    public Imovel(string endereco, decimal preco, string tipo)
    {
        //isso é as variaveis e oq elas recebem
        Endereco = endereco;
        Preco = preco;
        Tipo = tipo;
    }

    public override string ToString() //o tostring é pra facilitar a vida. ele permite que as informações sobre cada imóvel sejam exibidas de maneira legível e formatada.
    {
        return $"Endereço: {Endereco}, Preço: {Preco:C}, Tipo: {Tipo}";
    }
}
public class CorretoraDeImóveis
{
    private List<Imovel> imoveis; //isso cria a lista

    public CorretoraDeImóveis()
    {
        imoveis = new List<Imovel>(); //isso aqui faz a lista funcionar quando adiciona alguma coisa
    }

    public void InserirImovel(Imovel imovel)
    {
        imoveis.Add(imovel);
    }

    public void AlterarPrecoImovel(string endereco, decimal novoPreco)
    {
        Imovel imovel = imoveis.FirstOrDefault(i => i.Endereco == endereco);
        if (imovel != null)
        {
            imovel.Preco = novoPreco;
        }
        else
        {
            Console.WriteLine("Imóvel não encontrado.");
        }
    }

    public List<Imovel> ListarImoveis()
    {
        return imoveis; //esse mn volta todos os imoveis
    }

    public decimal CalcularValorMedio()
    {
        if (imoveis.Count == 0)
        {
            return 0;
        }
        return imoveis.Average(i => i.Preco);
    }
}

