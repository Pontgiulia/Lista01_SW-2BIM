using System;
using System.Collections.Generic;

public class Compra
{
    //essa parte é pra definir que tipo de dado é cada coisa
    public DateTime Data { get; set; }
    public string Produto { get; set; }
    public decimal Valor { get; set; }


    //isso é o construtor, ele inicializa os atributos Data, Produto e Valor quando uma nova instância de Compra é criada.
    public Compra(DateTime data, string produto, decimal valor)
    {
        //aqui é pra criar as variaveis e pra saber o que cada uma recebe
        Data = data;
        Produto = produto;
        Valor = valor;
    }

    public override string ToString()
    {
        //o tostring é pra retornar uma representação em string da compra, formatando a data e o valor de uma maneira fácil de ler.
        return $"Data: {Data.ToShortDateString()}, Produto: {Produto}, Valor: {Valor:C}";
    }
}

public class RegistroDeCompras
{
    //aqui tá criando uma lista, então tudo que for adicionado em compras vem pra cá
    private List<Compra> compras;


    //esse é o construtor, ele inicializa a lista quando uma compra for criada
    public RegistroDeCompras()
    {
        compras = new List<Compra>();
    }

    public void AdicionarCompra(Compra compra)
    {
        //isso é pra adicionar a compra
        compras.Add(compra);
    }

    public List<Compra> ListarCompras()
    {
        //esse retorna a compra, aí ela aparece pra gente
        return compras;
    }
}