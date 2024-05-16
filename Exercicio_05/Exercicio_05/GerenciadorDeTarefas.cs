using System;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorDeTarefas
{
    // Definindo a classe de Tarefa
    public class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        public override string ToString()
        {
            return $"Descrição: {Descricao}, Vencimento: {DataVencimento.ToShortDateString()}";
        }

        public bool DeveSerExecutadaHoje()
        {
            return DataVencimento.Date == DateTime.Today;
        }
    }

    private List<Tarefa> tarefas;

    // Construtor da classe GerenciadorDeTarefas
    public GerenciadorDeTarefas()
    {
        tarefas = new List<Tarefa>();
    }

    // Método para adicionar uma tarefa à lista
    public void AdicionarTarefa(string descricao, DateTime dataVencimento)
    {
        tarefas.Add(new Tarefa(descricao, dataVencimento));
    }

    // Método para remover uma tarefa da lista
    public void RemoverTarefa(string descricao)
    {
        Tarefa tarefa = tarefas.FirstOrDefault(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
        if (tarefa != null)
        {
            tarefas.Remove(tarefa);
            Console.WriteLine($"Tarefa \"{descricao}\" removida com sucesso.");
        }
        else
        {
            Console.WriteLine($"Tarefa \"{descricao}\" não encontrada na lista.");
        }
    }

    // Método para listar todas as tarefas
    public void ListarTarefas()
    {
        Console.WriteLine("Lista de Tarefas:");
        foreach (Tarefa tarefa in tarefas)
        {
            Console.WriteLine(tarefa);
        }
    }

    // Método para verificar se há tarefas a serem executadas hoje
    public void VerificarTarefasParaHoje()
    {
        List<Tarefa> tarefasParaHoje = tarefas.Where(t => t.DeveSerExecutadaHoje()).ToList();

        if (tarefasParaHoje.Count > 0)
        {
            Console.WriteLine("Tarefas a serem executadas hoje:");
            foreach (Tarefa tarefa in tarefasParaHoje)
            {
                Console.WriteLine(tarefa);
            }
        }
        else
        {
            Console.WriteLine("Não há tarefas a serem executadas hoje.");
        }
    }
}
