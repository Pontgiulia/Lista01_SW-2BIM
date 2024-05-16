using System;

public class Program
{
    public static void Main(string[] args)
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Remover tarefa");
            Console.WriteLine("3. Listar tarefas");
            Console.WriteLine("4. Verificar tarefas para hoje");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Data de vencimento (DD/MM/AAAA): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento))
                        {
                            gerenciador.AdicionarTarefa(descricao, dataVencimento);
                            Console.WriteLine("Tarefa adicionada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Data inválida.");
                        }
                        break;
                    case 2:
                        Console.Write("Descrição da tarefa a ser removida: ");
                        string descricaoRemover = Console.ReadLine();
                        gerenciador.RemoverTarefa(descricaoRemover);
                        break;
                    case 3:
                        gerenciador.ListarTarefas();
                        break;
                    case 4:
                        gerenciador.VerificarTarefasParaHoje();
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
