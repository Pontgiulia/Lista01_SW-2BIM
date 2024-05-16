using System;
using System.Collections.Generic;

public class Playlist
{
    private List<Musica> musicas;
    private string dono;

    public Playlist(string dono)
    {
        musicas = new List<Musica>();
        this.dono = dono;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void TocarMusicaAleatoria()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("Playlist vazia. Adicione músicas antes de tocar.");
            return;
        }

        Random random = new Random();
        int indice = random.Next(0, musicas.Count);
        Musica musicaTocada = musicas[indice];
        Console.WriteLine($"Tocando a música: {musicaTocada.Nome}");
    }
}
