using System;

public class Program
{
    public static void Main(string[] args)
    {
        AgendaTelefonica agenda = new AgendaTelefonica();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar contato");
            Console.WriteLine("2. Remover contato");
            Console.WriteLine("3. Buscar contato");
            Console.WriteLine("4. Listar contatos");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        agenda.AdicionarContato(nome, telefone, email);
                        Console.WriteLine("Contato adicionado com sucesso.");
                        break;
                    case 2:
                        Console.Write("Nome do contato a ser removido: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Nome do contato a ser buscado: ");
                        string nomeBuscar = Console.ReadLine();
                        AgendaTelefonica.Contato contato = agenda.BuscarContato(nomeBuscar);
                        if (contato != null)
                        {
                            Console.WriteLine("Contato encontrado:");
                            Console.WriteLine(contato);
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 4:
                        agenda.ListarContatos();
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

            Console.WriteLine();
        }
    }
}
