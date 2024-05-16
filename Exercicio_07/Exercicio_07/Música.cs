public class Musica
{
    public string Nome { get; set; }
    public string Autor { get; set; }
    public string Gravadora { get; set; }

    public Musica(string nome, string autor, string gravadora)
    {
        Nome = nome;
        Autor = autor;
        Gravadora = gravadora;
    }
}
