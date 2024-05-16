namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Produto
            Produto produto1 = new Produto("Camisa", 29.99, 50);

            Console.WriteLine($"Nome: {produto1.Nome}, Preço: R${produto1.Preco}, Quantidade em estoque: {produto1.QuantidadeEmEstoque}");

            produto1.AdicionarAoEstoque(20);
            Console.WriteLine($"Quantidade em estoque após adição: {produto1.QuantidadeEmEstoque}");

            produto1.RemoverDoEstoque(10);
            Console.WriteLine($"Quantidade em estoque após remoção: {produto1.QuantidadeEmEstoque}");

            Console.ReadKey();
        }
    }
}