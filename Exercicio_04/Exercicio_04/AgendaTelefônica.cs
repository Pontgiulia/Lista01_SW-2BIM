using System;
using System.Collections.Generic;
using System.Linq;

public class AgendaTelefonica
{
    // Definindo a classe de Contato
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
        }
    }

    private List<Contato> contatos;

    // Construtor da classe AgendaTelefonica
    public AgendaTelefonica()
    {
        contatos = new List<Contato>();
    }

    // Método para adicionar um contato à lista
    public void AdicionarContato(string nome, string telefone, string email)
    {
        contatos.Add(new Contato(nome, telefone, email));
    }

    // Método para remover um contato da lista
    public void RemoverContato(string nome)
    {
        Contato contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (contato != null)
        {
            contatos.Remove(contato);
            Console.WriteLine($"Contato \"{nome}\" removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Contato \"{nome}\" não encontrado na agenda.");
        }
    }

    // Método para buscar um contato na lista
    public Contato BuscarContato(string nome)
    {
        return contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    // Método para listar todos os contatos da agenda
    public void ListarContatos()
    {
        Console.WriteLine("Lista de Contatos:");
        foreach (Contato contato in contatos)
        {
            Console.WriteLine(contato);
        }
    }
}
