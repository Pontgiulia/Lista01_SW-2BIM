namespace Exercicio_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegistroDeCompras registro = new RegistroDeCompras();

            // Adicionando algumas compras. meio obvio né, copia e cola e troca o produto e valor. o now do DT é pra aparecer a data do momento real mesmo
            registro.AdicionarCompra(new Compra(DateTime.Now, "Notebook", 3500.00m));
            registro.AdicionarCompra(new Compra(DateTime.Now, "Smartphone", 1500.00m));
            registro.AdicionarCompra(new Compra(DateTime.Now, "Tablet", 850.00m));

            // Listando as compras. não precisa mexer nisso aqui, só serve para mostrar a lista com a data, produto e preço
            List<Compra> compras = registro.ListarCompras();
            foreach (Compra compra in compras)
            {
                Console.WriteLine(compra);
            }
        }
    }
}
