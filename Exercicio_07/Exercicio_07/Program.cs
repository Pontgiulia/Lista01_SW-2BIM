using System;

namespace Exercicio_07
{
        class Program
    {
        static void Main(string[] args)
        {
            // Criando algumas músicas
            Musica musica1 = new Musica("A rua", "Jão", "Universal Music Group");
            Musica musica2 = new Musica("Lábia", "Jão", "Universal Music Group");
            Musica musica3 = new Musica("Me lambe", "Jão", "Universal Music Group");

            // Criando uma playlist e adicionando as músicas
            Playlist playlist = new Playlist("Usuário");
            playlist.AdicionarMusica(musica1);
            playlist.AdicionarMusica(musica2);
            playlist.AdicionarMusica(musica3);

            // Tocando uma música aleatória
            playlist.TocarMusicaAleatoria();
        }
    }

}
